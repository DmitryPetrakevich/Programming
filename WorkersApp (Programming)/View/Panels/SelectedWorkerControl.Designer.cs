namespace WorkersApp__Programming_.View.Panels
{
    partial class SelectedWorkerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            SelectedWorkerGroupBox = new GroupBox();
            EmploymentTimePicker = new DateTimePicker();
            WorkersSalaryTextBox = new TextBox();
            WorkersPostTextBox = new TextBox();
            WorkersNameTextBox = new TextBox();
            salaryLabel = new Label();
            employmentLabel = new Label();
            postLabel = new Label();
            fullnameLabel = new Label();
            SelectedWorkerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedWorkerGroupBox
            // 
            SelectedWorkerGroupBox.Controls.Add(EmploymentTimePicker);
            SelectedWorkerGroupBox.Controls.Add(WorkersSalaryTextBox);
            SelectedWorkerGroupBox.Controls.Add(WorkersPostTextBox);
            SelectedWorkerGroupBox.Controls.Add(WorkersNameTextBox);
            SelectedWorkerGroupBox.Controls.Add(salaryLabel);
            SelectedWorkerGroupBox.Controls.Add(employmentLabel);
            SelectedWorkerGroupBox.Controls.Add(postLabel);
            SelectedWorkerGroupBox.Controls.Add(fullnameLabel);
            SelectedWorkerGroupBox.Dock = DockStyle.Fill;
            SelectedWorkerGroupBox.Location = new Point(0, 0);
            SelectedWorkerGroupBox.Name = "SelectedWorkerGroupBox";
            SelectedWorkerGroupBox.Size = new Size(612, 205);
            SelectedWorkerGroupBox.TabIndex = 2;
            SelectedWorkerGroupBox.TabStop = false;
            SelectedWorkerGroupBox.Text = "Selected Worker";
            // 
            // EmploymentTimePicker
            // 
            EmploymentTimePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmploymentTimePicker.Format = DateTimePickerFormat.Short;
            EmploymentTimePicker.ImeMode = ImeMode.NoControl;
            EmploymentTimePicker.Location = new Point(155, 113);
            EmploymentTimePicker.Name = "EmploymentTimePicker";
            EmploymentTimePicker.Size = new Size(250, 27);
            EmploymentTimePicker.TabIndex = 7;
            // 
            // WorkersSalaryTextBox
            // 
            WorkersSalaryTextBox.Location = new Point(155, 169);
            WorkersSalaryTextBox.Name = "WorkersSalaryTextBox";
            WorkersSalaryTextBox.Size = new Size(250, 27);
            WorkersSalaryTextBox.TabIndex = 6;
            WorkersSalaryTextBox.KeyPress += WorkersSalaryTextBox_KeyPress;
            // 
            // WorkersPostTextBox
            // 
            WorkersPostTextBox.Location = new Point(155, 64);
            WorkersPostTextBox.Name = "WorkersPostTextBox";
            WorkersPostTextBox.Size = new Size(250, 27);
            WorkersPostTextBox.TabIndex = 5;
            WorkersPostTextBox.KeyPress += WorkersPostTextBox_KeyPress;
            // 
            // WorkersNameTextBox
            // 
            WorkersNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WorkersNameTextBox.Location = new Point(155, 20);
            WorkersNameTextBox.Name = "WorkersNameTextBox";
            WorkersNameTextBox.Size = new Size(451, 27);
            WorkersNameTextBox.TabIndex = 4;
            WorkersNameTextBox.KeyPress += WorkerNameTextBox_KeyPress;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(97, 172);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(52, 20);
            salaryLabel.TabIndex = 3;
            salaryLabel.Text = "Salary:";
            // 
            // employmentLabel
            // 
            employmentLabel.AutoSize = true;
            employmentLabel.Location = new Point(17, 118);
            employmentLabel.Name = "employmentLabel";
            employmentLabel.Size = new Size(132, 20);
            employmentLabel.TabIndex = 2;
            employmentLabel.Text = "Employment Date:";
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.Location = new Point(110, 67);
            postLabel.Name = "postLabel";
            postLabel.Size = new Size(39, 20);
            postLabel.TabIndex = 1;
            postLabel.Text = "Post:";
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new Point(74, 23);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(75, 20);
            fullnameLabel.TabIndex = 0;
            fullnameLabel.Text = "FullName:";
            // 
            // SelectedWorkerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedWorkerGroupBox);
            Name = "SelectedWorkerControl";
            Size = new Size(612, 205);
            SelectedWorkerGroupBox.ResumeLayout(false);
            SelectedWorkerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SelectedWorkerGroupBox;
        public DateTimePicker EmploymentTimePicker;
        public TextBox WorkersSalaryTextBox;
        public TextBox WorkersPostTextBox;
        public TextBox WorkersNameTextBox;
        private Label salaryLabel;
        private Label employmentLabel;
        private Label postLabel;
        private Label fullnameLabel;
    }
}
