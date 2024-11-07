using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OSLab3.Process;

namespace OSLab3
{
    internal class TEST
    {
        public void SimulateRR(int quantumTime, int totalMemory)
        {
            systemTime = 0;
            int availableMemory = totalMemory;
            processes = processes.OrderBy(p => p.ArrivalTime).ToList();  // Сортируем по времени прибытия

            while (processes.Any(p => p.RemainingTime > 0))  // Продолжаем, пока есть процессы с оставшимся временем
            {
                bool progressMade = false;  // Флаг, чтобы проверить, был ли прогресс

                foreach (var process in processes)
                {
                    // Если процесс уже завершён, пропускаем его
                    if (process.RemainingTime <= 0)
                    {
                        process.Status = ProcessStatus.Completed;
                        continue;
                    }

                    // Процесс доступен по времени и памяти
                    if (process.ArrivalTime <= systemTime)
                    {
                        if (process.Memory <= availableMemory && process.Status != ProcessStatus.Running)
                        {
                            // Память доступна — запускаем процесс
                            availableMemory -= process.Memory;
                            process.Status = ProcessStatus.Running;

                            // Выполнение процесса
                            if (process.RemainingTime <= quantumTime)
                            {
                                systemTime += process.RemainingTime;
                                process.RemainingTime = 0;
                                availableMemory += process.Memory;  // Освобождаем память
                                process.Status = ProcessStatus.Completed;
                            }
                            else
                            {
                                process.RemainingTime -= quantumTime;
                                systemTime += quantumTime;
                            }

                            progressMade = true;
                        }
                        else if (process.Memory > availableMemory && process.Status != ProcessStatus.WaitingForMemory)
                        {
                            // Если памяти недостаточно — ставим процесс в очередь ожидания памяти
                            process.Status = ProcessStatus.WaitingForMemory;
                            progressMade = true;
                        }
                        else if (process.Status == ProcessStatus.WaitingForMemory)
                        {
                            // Если процесс в ожидании памяти, но память освободилась — обновляем статус
                            if (process.Memory <= availableMemory)
                            {
                                process.Status = ProcessStatus.Running;
                                availableMemory -= process.Memory;
                            }
                        }
                    }
                    else
                    {
                        // Процесс не может начать выполнение, он всё ещё в ожидании старта
                        process.Status = ProcessStatus.WaitingToStart;
                    }
                }

                tableView.RefreshProcessGridView(processes);

                // Если не было выполнено ни одного процесса, увеличиваем системное время
                if (!progressMade)
                {
                    systemTime++;  // Увеличиваем время, если не было прогресса
                    updateTimeCallBack(systemTime);
                    Application.DoEvents();
                    Thread.Sleep(500);
                }

                // Проверка на завершение всех процессов
                if (processes.All(p => p.RemainingTime == 0))
                {
                    break;
                }
            }

            MessageBox.Show("RR выполнен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
