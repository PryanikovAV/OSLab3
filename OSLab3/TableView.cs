using System;
using System.Drawing;
using System.Windows.Forms;

namespace OSLab3
{
    public class TableView
    {
        private DataGridView processGridView;
        private Label systemTimeLabel;


        public TableView(DataGridView processGridView, Label systemTimeLabel)
        {
            this.processGridView = processGridView;
            this.systemTimeLabel = systemTimeLabel;
        }
        
        public void UpdateTimeCallBack(int systemTime)
        {
            systemTimeLabel.Text = $"Системное время: {systemTime}";
        }
        
        public void UpdateProcessCallBack(Process process, string status)
        {
            foreach (DataGridViewRow row in processGridView.Rows)
            {
                if ((int)row.Cells["id"].Value == process.Id)
                {
                    row.Cells["remainingTime"].Value = process.RemainingTime;

                    switch (status)
                    {
                        case "Waiting":
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            break;
                        case "Running":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Completed":
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            break;
                    }
                    break;
                }
            }
        }
    }
}
