namespace OSLab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            arrivalTimeTextBox = new TextBox();
            burstTimeTextBox = new TextBox();
            memoryTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            systemTimeLabel = new Label();
            startSimulationButton = new Button();
            radioButtonRR = new RadioButton();
            radioButtonSJF = new RadioButton();
            groupBoxAlgorithm = new GroupBox();
            progressBarProcess = new ProgressBar();
            stopSimulationButton = new Button();
            addProcessButton = new Button();
            processGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            arrivalTime = new DataGridViewTextBoxColumn();
            burstTime = new DataGridViewTextBoxColumn();
            remainingTime = new DataGridViewTextBoxColumn();
            memory = new DataGridViewTextBoxColumn();
            groupBoxAlgorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)processGridView).BeginInit();
            SuspendLayout();
            // 
            // arrivalTimeTextBox
            // 
            arrivalTimeTextBox.Location = new Point(172, 443);
            arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            arrivalTimeTextBox.Size = new Size(125, 27);
            arrivalTimeTextBox.TabIndex = 3;
            // 
            // burstTimeTextBox
            // 
            burstTimeTextBox.Location = new Point(172, 476);
            burstTimeTextBox.Name = "burstTimeTextBox";
            burstTimeTextBox.Size = new Size(125, 27);
            burstTimeTextBox.TabIndex = 4;
            // 
            // memoryTextBox
            // 
            memoryTextBox.Location = new Point(172, 509);
            memoryTextBox.Name = "memoryTextBox";
            memoryTextBox.Size = new Size(125, 27);
            memoryTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 446);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 7;
            label2.Text = "Время появления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 479);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 8;
            label3.Text = "Время выполнения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 512);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Память";
            // 
            // systemTimeLabel
            // 
            systemTimeLabel.AutoSize = true;
            systemTimeLabel.Location = new Point(20, 390);
            systemTimeLabel.Name = "systemTimeLabel";
            systemTimeLabel.Size = new Size(148, 20);
            systemTimeLabel.TabIndex = 10;
            systemTimeLabel.Text = "Системное время: 0";
            // 
            // startSimulationButton
            // 
            startSimulationButton.Location = new Point(520, 507);
            startSimulationButton.Name = "startSimulationButton";
            startSimulationButton.Size = new Size(115, 29);
            startSimulationButton.TabIndex = 13;
            startSimulationButton.Text = "Начать";
            startSimulationButton.UseVisualStyleBackColor = true;
            startSimulationButton.Click += startSimulationButton_Click;
            // 
            // radioButtonRR
            // 
            radioButtonRR.AutoSize = true;
            radioButtonRR.Checked = true;
            radioButtonRR.Location = new Point(6, 26);
            radioButtonRR.Name = "radioButtonRR";
            radioButtonRR.Size = new Size(116, 24);
            radioButtonRR.TabIndex = 14;
            radioButtonRR.TabStop = true;
            radioButtonRR.Text = "Round Robin";
            radioButtonRR.UseVisualStyleBackColor = true;
            // 
            // radioButtonSJF
            // 
            radioButtonSJF.AutoSize = true;
            radioButtonSJF.Location = new Point(6, 56);
            radioButtonSJF.Name = "radioButtonSJF";
            radioButtonSJF.Size = new Size(50, 24);
            radioButtonSJF.TabIndex = 15;
            radioButtonSJF.TabStop = true;
            radioButtonSJF.Text = "SJF";
            radioButtonSJF.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlgorithm
            // 
            groupBoxAlgorithm.Controls.Add(radioButtonRR);
            groupBoxAlgorithm.Controls.Add(radioButtonSJF);
            groupBoxAlgorithm.Location = new Point(520, 390);
            groupBoxAlgorithm.Name = "groupBoxAlgorithm";
            groupBoxAlgorithm.Size = new Size(250, 87);
            groupBoxAlgorithm.TabIndex = 16;
            groupBoxAlgorithm.TabStop = false;
            groupBoxAlgorithm.Text = "Алгоритм планирования";
            // 
            // progressBarProcess
            // 
            progressBarProcess.Location = new Point(12, 352);
            progressBarProcess.Name = "progressBarProcess";
            progressBarProcess.Size = new Size(758, 29);
            progressBarProcess.TabIndex = 17;
            // 
            // stopSimulationButton
            // 
            stopSimulationButton.Location = new Point(655, 507);
            stopSimulationButton.Name = "stopSimulationButton";
            stopSimulationButton.Size = new Size(115, 29);
            stopSimulationButton.TabIndex = 18;
            stopSimulationButton.Text = "Остановить";
            stopSimulationButton.UseVisualStyleBackColor = true;
            stopSimulationButton.Click += stopSimulationButton_Click;
            // 
            // addProcessButton
            // 
            addProcessButton.Location = new Point(330, 507);
            addProcessButton.Name = "addProcessButton";
            addProcessButton.Size = new Size(115, 29);
            addProcessButton.TabIndex = 19;
            addProcessButton.Text = "Добавить";
            addProcessButton.UseVisualStyleBackColor = true;
            addProcessButton.Click += addProcessButton_Click;
            // 
            // processGridView
            // 
            processGridView.AllowUserToAddRows = false;
            processGridView.AllowUserToDeleteRows = false;
            processGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            processGridView.Columns.AddRange(new DataGridViewColumn[] { id, arrivalTime, burstTime, remainingTime, memory });
            processGridView.Location = new Point(12, 12);
            processGridView.Name = "processGridView";
            processGridView.ReadOnly = true;
            processGridView.RowHeadersWidth = 51;
            processGridView.Size = new Size(758, 334);
            processGridView.TabIndex = 20;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 60;
            // 
            // arrivalTime
            // 
            arrivalTime.HeaderText = "Время появления";
            arrivalTime.MinimumWidth = 6;
            arrivalTime.Name = "arrivalTime";
            arrivalTime.ReadOnly = true;
            arrivalTime.Width = 180;
            // 
            // burstTime
            // 
            burstTime.HeaderText = "Время выполнения";
            burstTime.MinimumWidth = 6;
            burstTime.Name = "burstTime";
            burstTime.ReadOnly = true;
            burstTime.Width = 180;
            // 
            // remainingTime
            // 
            remainingTime.HeaderText = "Оставшееся время";
            remainingTime.MinimumWidth = 6;
            remainingTime.Name = "remainingTime";
            remainingTime.ReadOnly = true;
            remainingTime.Width = 180;
            // 
            // memory
            // 
            memory.HeaderText = "Память";
            memory.MinimumWidth = 6;
            memory.Name = "memory";
            memory.ReadOnly = true;
            memory.Width = 90;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(processGridView);
            Controls.Add(addProcessButton);
            Controls.Add(stopSimulationButton);
            Controls.Add(progressBarProcess);
            Controls.Add(groupBoxAlgorithm);
            Controls.Add(startSimulationButton);
            Controls.Add(systemTimeLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(memoryTextBox);
            Controls.Add(burstTimeTextBox);
            Controls.Add(arrivalTimeTextBox);
            Name = "Form1";
            Text = "Form1";
            groupBoxAlgorithm.ResumeLayout(false);
            groupBoxAlgorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)processGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox processIdTextBox;
        private TextBox arrivalTimeTextBox;
        private TextBox burstTimeTextBox;
        private TextBox memoryTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label systemTimeLabel;
        private Button startSimulationButton;
        private DataGridViewTextBoxColumn Column1;
        private RadioButton radioButtonRR;
        private RadioButton radioButtonSJF;
        private GroupBox groupBoxAlgorithm;
        private ProgressBar progressBarProcess;
        private Button stopSimulationButton;
        private Button addProcessButton;
        private DataGridView processGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn arrivalTime;
        private DataGridViewTextBoxColumn burstTime;
        private DataGridViewTextBoxColumn remainingTime;
        private DataGridViewTextBoxColumn memory;
    }
}
