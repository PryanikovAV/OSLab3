using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OSLab3
{
    public partial class Form1 : Form
    {
        private int processId = 1;
        private int systemTime = 0;
        private List<Process> processList = new List<Process>();
        private Scheduler scheduler;
        private TableView tableView;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addProcessButton_Click(object sender, EventArgs e)
        {
            int arrivalTime = int.Parse(arrivalTimeTextBox.Text);
            int burstTime = int.Parse(burstTimeTextBox.Text);
            int memory = int.Parse(memoryTextBox.Text);

            Process process = new Process(processId++, arrivalTime, burstTime, memory);
            processList.Add(process);

            processGridView.Rows.Add(process.Id, process.ArrivalTime, process.BurstTime, process.RemainingTime, process.Memory);

            arrivalTimeTextBox.Clear();
            burstTimeTextBox.Clear();
            memoryTextBox.Clear();
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            if (processList.Count == 0)
            {
                MessageBox.Show("Планировщик процессов пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            systemTime = 0;
            systemTimeLabel.Text = $"Системное время: {systemTime}";
        }

        private void stopSimulationButton_Click(object sender, EventArgs e)
        {
            systemTime = 0;
            processList.Clear();
            processGridView.Rows.Clear();         
        }
    }
}
