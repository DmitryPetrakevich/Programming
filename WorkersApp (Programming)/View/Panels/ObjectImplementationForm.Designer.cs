namespace WorkersApp__Programming_.View.Panels
{
    partial class ObjectImplementationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectedWorkerGroupBox = new GroupBox();
            ApplyButton = new Button();
            CloseButton = new Button();
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
            SelectedWorkerGroupBox.Controls.Add(ApplyButton);
            SelectedWorkerGroupBox.Controls.Add(CloseButton);
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
            SelectedWorkerGroupBox.Size = new Size(550, 256);
            SelectedWorkerGroupBox.TabIndex = 5;
            SelectedWorkerGroupBox.TabStop = false;
            SelectedWorkerGroupBox.Text = "Selected Worker";
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(155, 215);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(94, 29);
            ApplyButton.TabIndex = 8;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(444, 215);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "Cancel";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // EmploymentTimePicker
            // 
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
            WorkersSalaryTextBox.TextChanged += WorkersSalaryTextBox_TextChanged;
            // 
            // WorkersPostTextBox
            // 
            WorkersPostTextBox.Location = new Point(155, 64);
            WorkersPostTextBox.Name = "WorkersPostTextBox";
            WorkersPostTextBox.Size = new Size(250, 27);
            WorkersPostTextBox.TabIndex = 5;
            WorkersPostTextBox.TextChanged += WorkersPostTextBox_TextChanged;
            // 
            // WorkersNameTextBox
            // 
            WorkersNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WorkersNameTextBox.Location = new Point(155, 20);
            WorkersNameTextBox.Name = "WorkersNameTextBox";
            WorkersNameTextBox.Size = new Size(383, 27);
            WorkersNameTextBox.TabIndex = 4;
            WorkersNameTextBox.TextChanged += WorkerNameTextBox_TextChanged;
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
            // ObjectImplementationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 256);
            Controls.Add(SelectedWorkerGroupBox);
            MaximizeBox = false;
            MaximumSize = new Size(568, 303);
            MinimizeBox = false;
            MinimumSize = new Size(568, 303);
            Name = "ObjectImplementationForm";
            Load += ObjectImplementationForm_Load;
            SelectedWorkerGroupBox.ResumeLayout(false);
            SelectedWorkerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SelectedWorkerGroupBox;
        private Button ApplyButton;
        private Button CloseButton;
        private DateTimePicker EmploymentTimePicker;
        private TextBox WorkersSalaryTextBox;
        private TextBox WorkersPostTextBox;
        private TextBox WorkersNameTextBox;
        private Label salaryLabel;
        private Label employmentLabel;
        private Label postLabel;
        private Label fullnameLabel;
    }
}