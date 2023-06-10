namespace WorkersApp__Programming_.View.Panels
{
    partial class WorkersListManagerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersListManagerControl));
            MainGridPanel = new TableLayoutPanel();
            SelectedWorkerControl = new SelectedWorkerControl();
            WorkersList_GroupBox = new GroupBox();
            EditWorkerInfoButton = new Button();
            DeleteWorkerButton = new Button();
            AddWorkerButton = new Button();
            WorkersListBox = new ListBox();
            MainGridPanel.SuspendLayout();
            WorkersList_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainGridPanel
            // 
            MainGridPanel.ColumnCount = 2;
            MainGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.875F));
            MainGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.125F));
            MainGridPanel.Controls.Add(SelectedWorkerControl, 1, 0);
            MainGridPanel.Controls.Add(WorkersList_GroupBox, 0, 0);
            MainGridPanel.Dock = DockStyle.Fill;
            MainGridPanel.Location = new Point(0, 0);
            MainGridPanel.Name = "MainGridPanel";
            MainGridPanel.RowCount = 1;
            MainGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MainGridPanel.Size = new Size(906, 565);
            MainGridPanel.TabIndex = 1;
            // 
            // SelectedWorkerControl
            // 
            SelectedWorkerControl.Dock = DockStyle.Top;
            SelectedWorkerControl.Location = new Point(291, 3);
            SelectedWorkerControl.Name = "SelectedWorkerControl";
            SelectedWorkerControl.Size = new Size(612, 211);
            SelectedWorkerControl.TabIndex = 5;
            // 
            // WorkersList_GroupBox
            // 
            WorkersList_GroupBox.Controls.Add(EditWorkerInfoButton);
            WorkersList_GroupBox.Controls.Add(DeleteWorkerButton);
            WorkersList_GroupBox.Controls.Add(AddWorkerButton);
            WorkersList_GroupBox.Controls.Add(WorkersListBox);
            WorkersList_GroupBox.Dock = DockStyle.Fill;
            WorkersList_GroupBox.Location = new Point(3, 3);
            WorkersList_GroupBox.Name = "WorkersList_GroupBox";
            WorkersList_GroupBox.Size = new Size(282, 559);
            WorkersList_GroupBox.TabIndex = 0;
            WorkersList_GroupBox.TabStop = false;
            // 
            // EditWorkerInfoButton
            // 
            EditWorkerInfoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditWorkerInfoButton.BackColor = Color.White;
            EditWorkerInfoButton.BackgroundImage = (Image)resources.GetObject("EditWorkerInfoButton.BackgroundImage");
            EditWorkerInfoButton.FlatAppearance.BorderColor = Color.White;
            EditWorkerInfoButton.FlatAppearance.BorderSize = 0;
            EditWorkerInfoButton.FlatStyle = FlatStyle.Flat;
            EditWorkerInfoButton.Location = new Point(66, 519);
            EditWorkerInfoButton.Name = "EditWorkerInfoButton";
            EditWorkerInfoButton.Size = new Size(24, 24);
            EditWorkerInfoButton.TabIndex = 4;
            EditWorkerInfoButton.UseVisualStyleBackColor = false;
            EditWorkerInfoButton.Click += EditWorkerInfoButton_Click;
            // 
            // DeleteWorkerButton
            // 
            DeleteWorkerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteWorkerButton.BackColor = Color.White;
            DeleteWorkerButton.BackgroundImage = (Image)resources.GetObject("DeleteWorkerButton.BackgroundImage");
            DeleteWorkerButton.FlatAppearance.BorderColor = Color.White;
            DeleteWorkerButton.FlatAppearance.BorderSize = 0;
            DeleteWorkerButton.FlatStyle = FlatStyle.Flat;
            DeleteWorkerButton.Location = new Point(36, 519);
            DeleteWorkerButton.Name = "DeleteWorkerButton";
            DeleteWorkerButton.Size = new Size(24, 24);
            DeleteWorkerButton.TabIndex = 3;
            DeleteWorkerButton.UseVisualStyleBackColor = false;
            DeleteWorkerButton.Click += DeleteWorkerButton_Click;
            // 
            // AddWorkerButton
            // 
            AddWorkerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddWorkerButton.BackColor = Color.White;
            AddWorkerButton.BackgroundImage = (Image)resources.GetObject("AddWorkerButton.BackgroundImage");
            AddWorkerButton.FlatAppearance.BorderColor = Color.White;
            AddWorkerButton.FlatAppearance.BorderSize = 0;
            AddWorkerButton.FlatStyle = FlatStyle.Flat;
            AddWorkerButton.Location = new Point(6, 519);
            AddWorkerButton.Name = "AddWorkerButton";
            AddWorkerButton.Size = new Size(24, 24);
            AddWorkerButton.TabIndex = 2;
            AddWorkerButton.UseVisualStyleBackColor = false;
            AddWorkerButton.Click += AddWorkerButton_Click;
            // 
            // WorkersListBox
            // 
            WorkersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WorkersListBox.BorderStyle = BorderStyle.None;
            WorkersListBox.FormattingEnabled = true;
            WorkersListBox.IntegralHeight = false;
            WorkersListBox.ItemHeight = 20;
            WorkersListBox.Location = new Point(6, 12);
            WorkersListBox.Name = "WorkersListBox";
            WorkersListBox.Size = new Size(270, 501);
            WorkersListBox.TabIndex = 1;
            WorkersListBox.SelectedIndexChanged += WorkersListBox_SelectedIndexChanged;
            // 
            // WorkersListManagerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainGridPanel);
            Name = "WorkersListManagerControl";
            Size = new Size(906, 565);
            Load += WorkersListManager_Load;
            MainGridPanel.ResumeLayout(false);
            WorkersList_GroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainGridPanel;
        private GroupBox WorkersList_GroupBox;
        private Button EditWorkerInfoButton;
        private Button DeleteWorkerButton;
        private Button AddWorkerButton;
        public ListBox WorkersListBox;
        private SelectedWorkerControl SelectedWorkerControl;
    }
}
