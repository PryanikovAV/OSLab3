using System;
using System.Collections.Generic;
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

            while (processes.Any(p => p.RemainingTime > 0))
            {
                foreach (var process in processes)
                {
                    if (process.RemainingTime > 0)
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
                }
            }

            MessageBox.Show("RR выполнен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
