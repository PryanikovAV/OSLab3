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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            availableMemoryLabel = new Label();
            systemDataGroupBox1 = new GroupBox();
            processButtonsBox1 = new GroupBox();
            processAddGroupBox1 = new GroupBox();
            groupBox1 = new GroupBox();
            groupBoxAlgorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)processGridView).BeginInit();
            systemDataGroupBox1.SuspendLayout();
            processButtonsBox1.SuspendLayout();
            processAddGroupBox1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // arrivalTimeTextBox
            // 
            arrivalTimeTextBox.Location = new Point(122, 26);
            arrivalTimeTextBox.Margin = new Padding(3, 2, 3, 2);
            arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            arrivalTimeTextBox.Size = new Size(110, 23);
            arrivalTimeTextBox.TabIndex = 3;
            // 
            // burstTimeTextBox
            // 
            burstTimeTextBox.Location = new Point(122, 53);
            burstTimeTextBox.Margin = new Padding(3, 2, 3, 2);
            burstTimeTextBox.Name = "burstTimeTextBox";
            burstTimeTextBox.Size = new Size(110, 23);
            burstTimeTextBox.TabIndex = 4;
            // 
            // memoryTextBox
            // 
            memoryTextBox.Location = new Point(122, 80);
            memoryTextBox.Margin = new Padding(3, 2, 3, 2);
            memoryTextBox.Name = "memoryTextBox";
            memoryTextBox.Size = new Size(110, 23);
            memoryTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 7;
            label2.Text = "Время появления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 8;
            label3.Text = "Время выполнения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 9;
            label4.Text = "Память";
            // 
            // systemTimeLabel
            // 
            systemTimeLabel.AutoSize = true;
            systemTimeLabel.CausesValidation = false;
            systemTimeLabel.Location = new Point(6, 44);
            systemTimeLabel.Name = "systemTimeLabel";
            systemTimeLabel.Size = new Size(117, 15);
            systemTimeLabel.TabIndex = 10;
            systemTimeLabel.Text = "Системное время: 0";
            // 
            // startButton
            // 
            startButton.Location = new Point(202, 15);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(92, 23);
            startButton.TabIndex = 13;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // radioButtonRR
            // 
            radioButtonRR.AutoSize = true;
            radioButtonRR.Checked = true;
            radioButtonRR.Location = new Point(5, 20);
            radioButtonRR.Margin = new Padding(3, 2, 3, 2);
            radioButtonRR.Name = "radioButtonRR";
            radioButtonRR.Size = new Size(94, 19);
            radioButtonRR.TabIndex = 14;
            radioButtonRR.TabStop = true;
            radioButtonRR.Text = "Round Robin";
            radioButtonRR.UseVisualStyleBackColor = true;
            // 
            // radioButtonSJFD
            // 
            radioButtonSJFD.AutoSize = true;
            radioButtonSJFD.Location = new Point(5, 42);
            radioButtonSJFD.Margin = new Padding(3, 2, 3, 2);
            radioButtonSJFD.Name = "radioButtonSJFD";
            radioButtonSJFD.Size = new Size(125, 19);
            radioButtonSJFD.TabIndex = 15;
            radioButtonSJFD.TabStop = true;
            radioButtonSJFD.Text = "SJF Вытесняющий";
            radioButtonSJFD.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlgorithm
            // 
            groupBoxAlgorithm.Controls.Add(radioButtonRR);
            groupBoxAlgorithm.Controls.Add(radioButtonSJFD);
            groupBoxAlgorithm.Location = new Point(570, 22);
            groupBoxAlgorithm.Margin = new Padding(3, 2, 3, 2);
            groupBoxAlgorithm.Name = "groupBoxAlgorithm";
            groupBoxAlgorithm.Padding = new Padding(3, 2, 3, 2);
            groupBoxAlgorithm.Size = new Size(200, 70);
            groupBoxAlgorithm.TabIndex = 16;
            groupBoxAlgorithm.TabStop = false;
            groupBoxAlgorithm.Text = "Алгоритм планирования";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(238, 53);
            resetButton.Margin = new Padding(3, 2, 3, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(92, 23);
            resetButton.TabIndex = 18;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(238, 80);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(92, 23);
            addButton.TabIndex = 19;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // processGridView
            // 
            processGridView.AllowUserToAddRows = false;
            processGridView.AllowUserToDeleteRows = false;
            processGridView.AllowUserToResizeRows = false;
            processGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            processGridView.Columns.AddRange(new DataGridViewColumn[] { id, arrivalTime, burstTime, remainingTime, memory });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            processGridView.DefaultCellStyle = dataGridViewCellStyle1;
            processGridView.Dock = DockStyle.Top;
            processGridView.Location = new Point(0, 0);
            processGridView.Margin = new Padding(3, 2, 3, 2);
            processGridView.MultiSelect = false;
            processGridView.Name = "processGridView";
            processGridView.ReadOnly = true;
            processGridView.RowHeadersWidth = 51;
            processGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            processGridView.Size = new Size(813, 448);
            processGridView.TabIndex = 20;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // arrivalTime
            // 
            arrivalTime.HeaderText = "Время появления";
            arrivalTime.MinimumWidth = 6;
            arrivalTime.Name = "arrivalTime";
            arrivalTime.ReadOnly = true;
            arrivalTime.Width = 200;
            // 
            // burstTime
            // 
            burstTime.HeaderText = "Время выполнения";
            burstTime.MinimumWidth = 6;
            burstTime.Name = "burstTime";
            burstTime.ReadOnly = true;
            burstTime.Width = 200;
            // 
            // remainingTime
            // 
            remainingTime.HeaderText = "Оставшееся время";
            remainingTime.MinimumWidth = 6;
            remainingTime.Name = "remainingTime";
            remainingTime.ReadOnly = true;
            remainingTime.Width = 200;
            // 
            // memory
            // 
            memory.HeaderText = "Память";
            memory.MinimumWidth = 6;
            memory.Name = "memory";
            memory.ReadOnly = true;
            memory.Width = 150;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(6, 15);
            pauseButton.Margin = new Padding(3, 2, 3, 2);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(92, 23);
            pauseButton.TabIndex = 21;
            pauseButton.Text = "Пауза";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(104, 15);
            continueButton.Margin = new Padding(3, 2, 3, 2);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(92, 23);
            continueButton.TabIndex = 22;
            continueButton.Text = "Продолжить";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // availableMemoryLabel
            // 
            availableMemoryLabel.AutoSize = true;
            availableMemoryLabel.Location = new Point(6, 22);
            availableMemoryLabel.Name = "availableMemoryLabel";
            availableMemoryLabel.Size = new Size(167, 15);
            availableMemoryLabel.TabIndex = 23;
            availableMemoryLabel.Text = "Доступная память: 100 из 100";
            // 
            // systemDataGroupBox1
            // 
            systemDataGroupBox1.Controls.Add(availableMemoryLabel);
            systemDataGroupBox1.Controls.Add(systemTimeLabel);
            systemDataGroupBox1.Location = new Point(360, 22);
            systemDataGroupBox1.Name = "systemDataGroupBox1";
            systemDataGroupBox1.Size = new Size(200, 70);
            systemDataGroupBox1.TabIndex = 24;
            systemDataGroupBox1.TabStop = false;
            systemDataGroupBox1.Text = "Системная информация";
            // 
            // processButtonsBox1
            // 
            processButtonsBox1.Anchor = AnchorStyles.None;
            processButtonsBox1.Controls.Add(pauseButton);
            processButtonsBox1.Controls.Add(continueButton);
            processButtonsBox1.Controls.Add(startButton);
            processButtonsBox1.Location = new Point(469, 98);
            processButtonsBox1.Name = "processButtonsBox1";
            processButtonsBox1.Size = new Size(301, 45);
            processButtonsBox1.TabIndex = 25;
            processButtonsBox1.TabStop = false;
            // 
            // processAddGroupBox1
            // 
            processAddGroupBox1.Controls.Add(label4);
            processAddGroupBox1.Controls.Add(label2);
            processAddGroupBox1.Controls.Add(arrivalTimeTextBox);
            processAddGroupBox1.Controls.Add(label3);
            processAddGroupBox1.Controls.Add(resetButton);
            processAddGroupBox1.Controls.Add(addButton);
            processAddGroupBox1.Controls.Add(burstTimeTextBox);
            processAddGroupBox1.Controls.Add(memoryTextBox);
            processAddGroupBox1.Location = new Point(6, 22);
            processAddGroupBox1.Name = "processAddGroupBox1";
            processAddGroupBox1.Size = new Size(342, 112);
            processAddGroupBox1.TabIndex = 26;
            processAddGroupBox1.TabStop = false;
            processAddGroupBox1.Text = "Добавление процессов";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(processAddGroupBox1);
            groupBox1.Controls.Add(systemDataGroupBox1);
            groupBox1.Controls.Add(processButtonsBox1);
            groupBox1.Controls.Add(groupBoxAlgorithm);
            groupBox1.Location = new Point(12, 453);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 156);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 624);
            Controls.Add(groupBox1);
            Controls.Add(processGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Планировщик процессов";
            groupBoxAlgorithm.ResumeLayout(false);
            groupBoxAlgorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)processGridView).EndInit();
            systemDataGroupBox1.ResumeLayout(false);
            systemDataGroupBox1.PerformLayout();
            processButtonsBox1.ResumeLayout(false);
            processAddGroupBox1.ResumeLayout(false);
            processAddGroupBox1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        // private TextBox processIdTextBox;
        private TextBox arrivalTimeTextBox;
        private TextBox burstTimeTextBox;
        private TextBox memoryTextBox;
        // private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label systemTimeLabel;
        private Button startButton;
        // private DataGridViewTextBoxColumn Column1;
        private RadioButton radioButtonRR;
        private RadioButton radioButtonSJFD;
        private GroupBox groupBoxAlgorithm;
        private Button resetButton;
        private Button addButton;
        private DataGridView processGridView;
        private Button pauseButton;
        private Button continueButton;
        private Label availableMemoryLabel;
        private GroupBox systemDataGroupBox1;
        private GroupBox processButtonsBox1;
        private GroupBox processAddGroupBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn arrivalTime;
        private DataGridViewTextBoxColumn burstTime;
        private DataGridViewTextBoxColumn remainingTime;
        private DataGridViewTextBoxColumn memory;
        private GroupBox groupBox1;
    }
}
