namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.HeightRectangleLabel = new System.Windows.Forms.Label();
            this.WidthRectangleLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.HeightRectangleTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.AutoSize = true;
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(271, 6);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(779, 597);
            this.CanvasPanel.TabIndex = 31;
            // 
            // HeightRectangleLabel
            // 
            this.HeightRectangleLabel.AutoSize = true;
            this.HeightRectangleLabel.Location = new System.Drawing.Point(29, 350);
            this.HeightRectangleLabel.Name = "HeightRectangleLabel";
            this.HeightRectangleLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightRectangleLabel.TabIndex = 30;
            this.HeightRectangleLabel.Text = "Height:";
            // 
            // WidthRectangleLabel
            // 
            this.WidthRectangleLabel.AutoSize = true;
            this.WidthRectangleLabel.Location = new System.Drawing.Point(32, 324);
            this.WidthRectangleLabel.Name = "WidthRectangleLabel";
            this.WidthRectangleLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthRectangleLabel.TabIndex = 29;
            this.WidthRectangleLabel.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(53, 298);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 28;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(53, 272);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 27;
            this.XLabel.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(51, 246);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 26;
            this.IdLabel.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selected Rectangle:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(76, 295);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 24;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // HeightRectangleTextBox
            // 
            this.HeightRectangleTextBox.Location = new System.Drawing.Point(76, 347);
            this.HeightRectangleTextBox.Name = "HeightRectangleTextBox";
            this.HeightRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightRectangleTextBox.TabIndex = 23;
            this.HeightRectangleTextBox.TextChanged += new System.EventHandler(this.HeightRectangleTextBox_TextChanged);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(76, 321);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthRectangleTextBox.TabIndex = 22;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(76, 243);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 21;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(76, 269);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 20;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // RectangleLabel
            // 
            this.RectangleLabel.AutoSize = true;
            this.RectangleLabel.Location = new System.Drawing.Point(15, 6);
            this.RectangleLabel.Name = "RectangleLabel";
            this.RectangleLabel.Size = new System.Drawing.Size(64, 13);
            this.RectangleLabel.TabIndex = 19;
            this.RectangleLabel.Text = "Rectangles:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(18, 22);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(247, 160);
            this.RectangleListBox.TabIndex = 18;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(190, 188);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(75, 26);
            this.RemoveRectangleButton.TabIndex = 17;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_ButtonEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_ButtonLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(18, 188);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(75, 26);
            this.AddRectangleButton.TabIndex = 16;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_ButtonEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_ButtonLeave);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.HeightRectangleLabel);
            this.Controls.Add(this.WidthRectangleLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.HeightRectangleTextBox);
            this.Controls.Add(this.WidthRectangleTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.RectangleLabel);
            this.Controls.Add(this.RectangleListBox);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(1056, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label HeightRectangleLabel;
        private System.Windows.Forms.Label WidthRectangleLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox HeightRectangleTextBox;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label RectangleLabel;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
    }
}
