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
                systemTime += timeSlice;
                process.RemainingTime -= timeSlice;

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


        //public void SimulateRR(int quantumTime, int totalMemory)
        //{
        //    systemTime = 0;
        //    availableMemory = totalMemory;

        //    processes = processes.OrderBy(p => p.ArrivalTime).ToList();

        //    while (processes.Any(p => p.RemainingTime > 0))
        //    {
        //        foreach (var process in processes)
        //        {
        //            if (process.Status == Process.ProcessStatus.Completed)
        //            {
        //                continue;
        //            }
        //            else if (process.RemainingTime == 0)
        //            {
        //                process.Status = Process.ProcessStatus.Completed;
        //            }
        //            else if (process.ArrivalTime > systemTime)
        //            {
        //                process.Status = Process.ProcessStatus.WaitingToStart;
        //            }
        //            else if (process.Memory > availableMemory)
        //            {
        //                process.Status= Process.ProcessStatus.WaitingForMemory;
        //            }

        //            else if (process.ArrivalTime >= systemTime)
        //            {
        //                if (process.RemainingTime <= quantumTime && process.Status != Process.ProcessStatus.Running)
        //                {
        //                    // запустим процесс на 1 такт для демонстрации
        //                    availableMemory -= process.Memory;
        //                    systemTime += process.RemainingTime;
        //                    process.RemainingTime = 0;
        //                    process.Status = Process.ProcessStatus.Running;

        //                    tableView.RefreshProcessGridView(processes);
        //                    updateMemoryCallBack(availableMemory, totalMemory);
        //                    Application.DoEvents();
        //                    Thread.Sleep(700);

        //                    //после завершим процесс
        //                    availableMemory += process.Memory;
        //                    process.Status = Process.ProcessStatus.Completed;
        //                }
        //                else if (process.RemainingTime > quantumTime && process.Status != Process.ProcessStatus.Running)
        //                {
        //                    systemTime += quantumTime;
        //                    availableMemory -= process.Memory;
        //                    process.RemainingTime -= quantumTime;
        //                    process.Status = Process.ProcessStatus.Running;
        //                }
        //                else if (process.RemainingTime <= quantumTime && process.Status == Process.ProcessStatus.Running)
        //                {
        //                    systemTime += process.RemainingTime;
        //                    process.RemainingTime = 0;
        //                    availableMemory += process.Memory;
        //                    process.Status = Process.ProcessStatus.Completed;
        //                }
        //                else if (process.RemainingTime > quantumTime && process.Status == Process.ProcessStatus.Running)
        //                {
        //                    systemTime += quantumTime;
        //                    process.RemainingTime -= quantumTime;
        //                }
        //                else
        //                {
        //                    systemTime += quantumTime;
        //                }
        //            }

        //            tableView.RefreshProcessGridView(processes);
        //            updateTimeCallBack(systemTime);
        //            updateMemoryCallBack(availableMemory, totalMemory);
        //            Application.DoEvents();
        //            Thread.Sleep(700);
        //        }
        //    }

        //    MessageBox.Show("Round Robin завершён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //public void SimulateSJFD(int totalMemory)
        //{
        //    systemTime = 0;
        //    availableMemory = totalMemory;


        //    while (processes.Any(p => p.Status != Process.ProcessStatus.Completed))
        //    {
        //        var readyProcesses = processes
        //            .Where(p => p.ArrivalTime <= systemTime && p.Status != Process.ProcessStatus.Completed)
        //            .OrderBy(p => p.RemainingTime)
        //            .ToList();

        //        var process = readyProcesses.FirstOrDefault(p => p.Status == Process.ProcessStatus.WaitingToStart && p.Memory <= availableMemory);
        //        if (process != null)
        //        {
        //            availableMemory -= process.Memory;
        //            process.Status = Process.ProcessStatus.Running;
        //        }

        //        var runningProcess = readyProcesses.FirstOrDefault(p => p.Status == Process.ProcessStatus.Running);
        //        if (runningProcess != null)
        //        {
        //            runningProcess.RemainingTime--;
        //            systemTime++;

        //            // Обновляем интерфейс и добавляем задержку для визуализации
        //            updateTimeCallBack(systemTime);
        //            tableView.RefreshProcessGridView(processes);
        //            Thread.Sleep(700);

        //            if (runningProcess.RemainingTime == 0)
        //            {
        //                runningProcess.Status = Process.ProcessStatus.Completed;
        //                availableMemory += runningProcess.Memory;
        //            }
        //        }
        //        else
        //        {
        //            systemTime++;
        //            updateTimeCallBack(systemTime);
        //            Thread.Sleep(700);
        //        }
        //    }

        //    MessageBox.Show("SJF с вытеснением завершён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
    }
}