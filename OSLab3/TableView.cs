using System;
using System.Drawing;
using System.Windows.Forms;
using static OSLab3.Process;

namespace OSLab3
{
    public class TableView
    {
        private DataGridView processGridView;
        private Label systemTimeLabel;
        private Label availableMemoryLabel;


        public TableView(DataGridView processGridView, Label systemTimeLabel, Label availableMemoryLabel)
        {
            this.processGridView = processGridView;
            this.systemTimeLabel = systemTimeLabel;
            this.availableMemoryLabel = availableMemoryLabel;
        }
        
        public void UpdateTimeCallBack(int systemTime)
        {
            systemTimeLabel.Text = $"Системное время: {systemTime}";
        }

        public void UpdateMemoryCallBack(int availableMemory, int totalMemory)
        {
            availableMemoryLabel.Text = $"Доступная память: {availableMemory} из {totalMemory}";
        }

        public void RefreshProcessGridView(List<Process> processes)
        {
            foreach (DataGridViewRow row in processGridView.Rows)
            {
                int processId = (int)row.Cells["id"].Value;
                var process = processes.FirstOrDefault(p => p.Id == processId);

                if (process != null)
                {
                    row.Cells["remainingTime"].Value = process.RemainingTime;

                    switch (process.Status)
                    {
                        case ProcessStatus.WaitingToStart:
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            break;
                        case ProcessStatus.WaitingForMemory:
                            row.DefaultCellStyle.BackColor = Color.Orange;
                            break;
                        case ProcessStatus.Running:
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case ProcessStatus.Completed:
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            break;
                    }
                }
            }
        }
    }
}
