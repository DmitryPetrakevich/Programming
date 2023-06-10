namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.Controls.Add(this.ParseLabel);
            this.ParsingGroupBox.Controls.Add(this.WeekdayLabel);
            this.ParsingGroupBox.Controls.Add(this.ParseButton);
            this.ParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.ParsingGroupBox.Location = new System.Drawing.Point(2, 2);
            this.ParsingGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ParsingGroupBox.Size = new System.Drawing.Size(255, 109);
            this.ParsingGroupBox.TabIndex = 7;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Location = new System.Drawing.Point(6, 66);
            this.ParseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(0, 13);
            this.ParseLabel.TabIndex = 3;
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Location = new System.Drawing.Point(2, 26);
            this.WeekdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(112, 13);
            this.WeekdayLabel.TabIndex = 2;
            this.WeekdayLabel.Text = "Type value of parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(157, 39);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(2);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(56, 22);
            this.ParseButton.TabIndex = 1;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(4, 41);
            this.ParseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ParseTextBox.Multiline = true;
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(149, 20);
            this.ParseTextBox.TabIndex = 0;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsingGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(262, 114);
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Label ParseLabel;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseTextBox;
    }
}
