using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Threading;

namespace OSLab3
{
    public class Scheduler
    {
        private List<Process> processes;
        private Action<int> updateTimeCallBack;
        private Action<Process, string> updateProcessCallBack;
        private int systemTime = 0;

        public Scheduler(List<Process> processes,
            Action<int> updateTimeCallBack,
            Action<Process, string> updateProcessCallBack)
        {
            this.processes = processes;
            this.updateTimeCallBack = updateTimeCallBack;
            this.updateProcessCallBack = updateProcessCallBack;
        }


        public void SimulateRR(int quantumTime)
        {
            systemTime = 0;

            processes = processes.OrderBy(p => p.ArrivalTime).ToList();  // сперва сортируем

            while (processes.Any(p => p.RemainingTime > 0))
            {
                foreach (var process in processes)
                {
                    if (process.RemainingTime > 0 && process.ArrivalTime <= systemTime)
                    {
                        updateProcessCallBack(process, "Waiting");  // процесс в очереди == жёлтый
                        Application.DoEvents();  // <-- обновление интерфейса
                        Thread.Sleep(700);

                        if (process.RemainingTime <= quantumTime)
                        {
                            systemTime += process.RemainingTime;
                            process.RemainingTime = 0;
                            updateProcessCallBack(process, "Completed");  // завершён == серый
                        }
                        else
                        {
                            process.RemainingTime -= quantumTime;
                            systemTime += quantumTime;
                            updateProcessCallBack(process, "Running");  // в процессе == зелёный
                        }

                        updateTimeCallBack(systemTime);
                        Application.DoEvents();  // <-- обновление интерфейса
                        Thread.Sleep(700);
                    }
                    else if (process.RemainingTime > 0 && process.ArrivalTime > systemTime)
                    {
                        systemTime += quantumTime;
                        updateProcessCallBack(process, "Waiting");
                        updateTimeCallBack(systemTime);
                        Application.DoEvents();  // <-- обновление интерфейса
                        Thread.Sleep(700);
                    }
                }
            }

            MessageBox.Show("RR выполнен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SimulateSJFD()
        {
            systemTime = 0;

            while (processes.Any(p => p.RemainingTime > 0))
            {
                var process = processes  // 
                    .Where(p => p.ArrivalTime <= systemTime && p.RemainingTime > 0)
                    .OrderBy(p => p.RemainingTime)
                    .FirstOrDefault();  // <-- первый элемент сорт. списка

                if (process != null)
                {
                    process.RemainingTime -= 1;
                    systemTime += 1;
                    updateProcessCallBack(process, "Running");
                    updateTimeCallBack(systemTime);
                    Application.DoEvents();
                    Thread.Sleep(700);

                    if (process.RemainingTime == 0)
                    {
                        updateProcessCallBack(process, "Completed"); // процесс завершён => СЕРЫЙ
                        Application.DoEvents();
                        Thread.Sleep(700);
                    }
                }
                else
                {
                    while (!processes.Any(p => p.RemainingTime > 0 && p.ArrivalTime <= systemTime))
                    {
                        systemTime++;
                        updateTimeCallBack(systemTime);
                        Application.DoEvents();
                        Thread.Sleep(700);
                    }
                }
                foreach (var p in processes.Where(p => p.ArrivalTime <= systemTime && p.RemainingTime > 0 && p != process))
                {
                    updateProcessCallBack(p, "Waiting");  // <--все остальнеы процессы в ЖЁЛТЫЙ
                }
            }
            MessageBox.Show("SJF с вытеснением завершён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}