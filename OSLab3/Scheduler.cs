using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using System.Xml;

namespace OSLab3
{
    public class Scheduler
    {
        private List<Process> processes;
        private Action<int> updateTimeCallBack;
        private Action<int, int> updateMemoryCallBack;
        private TableView tableView;
        private int systemTime = 0;
        private int availableMemory;
        private bool isPaused = false;  // <-- Pause / Continue

        public Scheduler(List<Process> processes, 
            Action<int> updateTimeCallBack, 
            Action<int, int> updateMemoryCallBack, 
            TableView tableView)
        {
            this.processes = processes;
            this.updateTimeCallBack = updateTimeCallBack;
            this.updateMemoryCallBack = updateMemoryCallBack;
            this.tableView = tableView;
        }

        public void Pause()  // Pause
        {
            isPaused = true;
        }

        public void ContinueSimulation()  // Continue
        {
            isPaused = false;
        }

        private async Task WaitIfPaused()  // ожидание Pause
        {
            while (isPaused)
            {
                await Task.Delay(100); // пока isPaused не станет false
            }
        }

        public async Task SimulateRR(int quantumTime, int totalMemory)
        {
            systemTime = 0;
            availableMemory = totalMemory;
            int currentIndex = 0;  // <-- вместо foreach

            processes = processes.OrderBy(p => p.ArrivalTime).ToList();

            while (processes.Any(p => p.Status != Process.ProcessStatus.Completed))
            {
                await WaitIfPaused(); // <-- ожидание, если Pause

                var process = processes[currentIndex];

                // пропускаем завершённые процессы
                if (process.Status == Process.ProcessStatus.Completed)
                {
                    currentIndex = (currentIndex + 1) % processes.Count;
                    continue;
                }

                // если процесс ещё не прибыл, пропускаем его
                if (process.ArrivalTime > systemTime)
                {
                    process.Status = Process.ProcessStatus.WaitingToStart;
                    systemTime += 1;  // <-- исправление зацикливания, если нет процессов СЕЙЧАС в работе
                    currentIndex = (currentIndex + 1) % processes.Count;
                    continue;
                }

                // если мало памяти -> WaitingForMemory
                if (process.Memory > availableMemory && process.Status != Process.ProcessStatus.Running)
                {
                    process.Status = Process.ProcessStatus.WaitingForMemory;
                    currentIndex = (currentIndex + 1) % processes.Count;
                    continue;
                }

                // если процесс готов -> Running
                if (process.Status == Process.ProcessStatus.WaitingToStart || process.Status == Process.ProcessStatus.WaitingForMemory)
                {
                    process.Status = Process.ProcessStatus.Running;
                    availableMemory -= process.Memory;
                }


                int timeSlice = Math.Min(quantumTime, process.RemainingTime);
                if (timeSlice > 0)
                {
                    systemTime += timeSlice;
                    process.RemainingTime -= timeSlice;
                }
                else
                {
                    systemTime += quantumTime;
                }
                
                
                if (process.RemainingTime <= 0)
                {
                    process.Status = Process.ProcessStatus.Completed;
                    availableMemory += process.Memory;
                }


                tableView.RefreshProcessGridView(processes);
                updateTimeCallBack(systemTime);
                updateMemoryCallBack(availableMemory, totalMemory);
                Application.DoEvents();
                await Task.Delay(700);

                currentIndex = (currentIndex + 1) % processes.Count;
            }

            MessageBox.Show("Round Robin завершён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public async Task SimulateSJFP(int totalMemory)
        {
            systemTime = 0;
            availableMemory = totalMemory;
            Process currentProcess = null;

            processes = processes.OrderBy(p => p.ArrivalTime).ToList();

            while (processes.Any(p => p.Status != Process.ProcessStatus.Completed))
            {
                await WaitIfPaused(); // <-- ожидание, если Pause

                
                var readyProcesses = processes  // список: запуск-ОК / не завершён / память-ОК
                    .Where(p => p.ArrivalTime <= systemTime && p.Status != Process.ProcessStatus.Completed && p.Memory <= availableMemory)
                    .OrderBy(p => p.RemainingTime)
                    .ToList();

                
                if (readyProcesses.Any())
                {
                    var nextProcess = readyProcesses.First();

                    if (currentProcess != nextProcess)  // переходим к след. процессу, если он есть
                    {
                        // изначально доп условие:  currentProcess.Status == Process.ProcessStatus.Running...
                        if (currentProcess != null && currentProcess.Status == Process.ProcessStatus.Running)
                        {
                            currentProcess.Status = Process.ProcessStatus.WaitingToStart;
                            availableMemory += currentProcess.Memory;
                        }

                        currentProcess = nextProcess;
                        currentProcess.Status = Process.ProcessStatus.Running;
                        availableMemory -= currentProcess.Memory;
                    }

                    currentProcess.RemainingTime--;
                    systemTime++;

                    if (currentProcess.RemainingTime <= 0)
                    {
                        currentProcess.Status = Process.ProcessStatus.Completed;
                        availableMemory += currentProcess.Memory;
                        currentProcess = null;
                    }
                }
                else
                {
                    systemTime++;
                }

                tableView.RefreshProcessGridView(processes);
                updateTimeCallBack(systemTime);
                updateMemoryCallBack(availableMemory, totalMemory);
                Application.DoEvents();
                await Task.Delay(700);
            }

            MessageBox.Show("SJF вытесняющий завершён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}