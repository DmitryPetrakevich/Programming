namespace WorkersApp__Programming_.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            WorkersListManagerControl = new Panels.WorkersListManagerControl();
            SuspendLayout();
            // 
            // WorkersListManagerControl
            // 
            WorkersListManagerControl.Dock = DockStyle.Fill;
            WorkersListManagerControl.Location = new Point(0, 0);
            WorkersListManagerControl.Name = "WorkersListManagerControl";
            WorkersListManagerControl.Size = new Size(800, 450);
            WorkersListManagerControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WorkersListManagerControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(818, 497);
            Name = "MainForm";
            Text = "WorkersApp";
            ResumeLayout(false);
        }

        #endregion

        private Panels.WorkersListManagerControl WorkersListManagerControl;
    }
}