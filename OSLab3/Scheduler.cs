using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using System.Xml;
using static OSLab3.Process;

namespace OSLab3
{
    public class Scheduler
    {
        private List<Process> processes;
        private Action<int> updateTimeCallBack;
        private TableView tableView;
        private int systemTime = 0;

        public Scheduler(List<Process> processes, Action<int> updateTimeCallBack, TableView tableView)
        {
            this.processes = processes;
            this.updateTimeCallBack = updateTimeCallBack;
            this.tableView = tableView;
        }

        public void SimulateRR(int quantumTime, int totalMemory)
        {
            systemTime = 0;
            int availableMemory = totalMemory;
            processes = processes.OrderBy(p => p.ArrivalTime).ToList();

            while (processes.Any(p => p.RemainingTime > 0))
            {
                while (availableMemory > 0)
                {
                    if (process)
                }
            }
        }
        


        public void SimulateSJFD(int totalMemory)
        {
            systemTime = 0;

            while (processes.Any(p => p.RemainingTime > 0))
            {
                var process = processes
                    .Where(p => p.ArrivalTime <= systemTime && p.RemainingTime > 0)
                    .OrderBy(p => p.RemainingTime)
                    .FirstOrDefault();

                if (process != null)
                {
                    process.RemainingTime -= 1;
                    systemTime += 1;
                    updateTimeCallBack(systemTime);
                    Application.DoEvents();
                    Thread.Sleep(700);

                    if (process.RemainingTime == 0)
                    {
                        process.Status = ProcessStatus.Completed;
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
                    p.Status = ProcessStatus.WaitingToStart;
                }
            }

            MessageBox.Show("SJF с вытеснением завершён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }    
}