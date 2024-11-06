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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            arrivalTimeTextBox = new TextBox();
            burstTimeTextBox = new TextBox();
            memoryTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            systemTimeLabel = new Label();
            startButton = new Button();
            radioButtonRR = new RadioButton();
            radioButtonSJFD = new RadioButton();
            groupBoxAlgorithm = new GroupBox();
            progressBarProcess = new ProgressBar();
            resetButton = new Button();
            addButton = new Button();
            processGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            arrivalTime = new DataGridViewTextBoxColumn();
            burstTime = new DataGridViewTextBoxColumn();
            remainingTime = new DataGridViewTextBoxColumn();
            memory = new DataGridViewTextBoxColumn();
            pauseButton = new Button();
            continueButton = new Button();
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
            label2.Location = new Point(12, 446);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 7;
            label2.Text = "Время появления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 479);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 8;
            label3.Text = "Время выполнения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 512);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Память";
            // 
            // systemTimeLabel
            // 
            systemTimeLabel.AutoSize = true;
            systemTimeLabel.CausesValidation = false;
            systemTimeLabel.Location = new Point(12, 384);
            systemTimeLabel.Name = "systemTimeLabel";
            systemTimeLabel.Size = new Size(148, 20);
            systemTimeLabel.TabIndex = 10;
            systemTimeLabel.Text = "Системное время: 0";
            // 
            // startButton
            // 
            startButton.Location = new Point(665, 509);
            startButton.Name = "startButton";
            startButton.Size = new Size(105, 29);
            startButton.TabIndex = 13;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
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
            // radioButtonSJFD
            // 
            radioButtonSJFD.AutoSize = true;
            radioButtonSJFD.Location = new Point(6, 56);
            radioButtonSJFD.Name = "radioButtonSJFD";
            radioButtonSJFD.Size = new Size(154, 24);
            radioButtonSJFD.TabIndex = 15;
            radioButtonSJFD.TabStop = true;
            radioButtonSJFD.Text = "SJF Вытесняющий";
            radioButtonSJFD.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlgorithm
            // 
            groupBoxAlgorithm.Controls.Add(radioButtonRR);
            groupBoxAlgorithm.Controls.Add(radioButtonSJFD);
            groupBoxAlgorithm.Location = new Point(554, 383);
            groupBoxAlgorithm.Name = "groupBoxAlgorithm";
            groupBoxAlgorithm.Size = new Size(216, 87);
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
            // resetButton
            // 
            resetButton.Location = new Point(414, 509);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(105, 29);
            resetButton.TabIndex = 18;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(303, 509);
            addButton.Name = "addButton";
            addButton.Size = new Size(105, 29);
            addButton.TabIndex = 19;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // processGridView
            // 
            processGridView.AllowUserToAddRows = false;
            processGridView.AllowUserToDeleteRows = false;
            processGridView.AllowUserToResizeColumns = false;
            processGridView.AllowUserToResizeRows = false;
            processGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            processGridView.Columns.AddRange(new DataGridViewColumn[] { id, arrivalTime, burstTime, remainingTime, memory });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            processGridView.DefaultCellStyle = dataGridViewCellStyle3;
            processGridView.Location = new Point(12, 12);
            processGridView.MultiSelect = false;
            processGridView.Name = "processGridView";
            processGridView.ReadOnly = true;
            processGridView.RowHeadersWidth = 51;
            processGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
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
            // pauseButton
            // 
            pauseButton.Location = new Point(554, 474);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(105, 29);
            pauseButton.TabIndex = 21;
            pauseButton.Text = "Пауза";
            pauseButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(665, 474);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(105, 29);
            continueButton.TabIndex = 22;
            continueButton.Text = "Продолжить";
            continueButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(continueButton);
            Controls.Add(pauseButton);
            Controls.Add(processGridView);
            Controls.Add(addButton);
            Controls.Add(resetButton);
            Controls.Add(progressBarProcess);
            Controls.Add(groupBoxAlgorithm);
            Controls.Add(startButton);
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
        private Button startButton;
        private DataGridViewTextBoxColumn Column1;
        private RadioButton radioButtonRR;
        private RadioButton radioButtonSJFD;
        private GroupBox groupBoxAlgorithm;
        private ProgressBar progressBarProcess;
        private Button resetButton;
        private Button addButton;
        private DataGridView processGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn arrivalTime;
        private DataGridViewTextBoxColumn burstTime;
        private DataGridViewTextBoxColumn remainingTime;
        private DataGridViewTextBoxColumn memory;
        private Button pauseButton;
        private Button continueButton;
    }
}
