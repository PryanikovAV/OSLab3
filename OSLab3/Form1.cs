using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OSLab3
{
    public partial class Form1 : Form
    {
        private int processId = 1;
        private List<Process> processList = new List<Process>();
        private Scheduler scheduler;
        private TableView tableView;

        public Form1()
        {
            InitializeComponent();

            tableView = new TableView(processGridView, systemTimeLabel);
            scheduler = new Scheduler(
                processList,
                tableView.UpdateTimeCallBack,
                tableView.UpdateProcessCallBack);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(arrivalTimeTextBox.Text, out int arrivalTime) ||
                !int.TryParse(burstTimeTextBox.Text, out int burstTime) ||
                !int.TryParse(memoryTextBox.Text, out int memory))
            {
                MessageBox.Show("Введите корректные данные", "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Process process = new Process(processId++, arrivalTime, burstTime, memory);
            processList.Add(process);

            processGridView.Rows.Add(process.Id, process.ArrivalTime, process.BurstTime, process.RemainingTime, process.Memory);

            arrivalTimeTextBox.Clear();
            burstTimeTextBox.Clear();
            memoryTextBox.Clear();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int quantumTime = 3;

            if (radioButtonRR.Checked)
            {
                scheduler.SimulateRR(quantumTime);
            }
            else if (radioButtonSJFD.Checked)
            {
                scheduler.SimulateSJFD();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            processGridView.Rows.Clear();
            processList.Clear();          
            systemTimeLabel.Text = $"Системное время: 0";
            // Удалить статус, напр. "RR выполнен"
        }
    }
}
