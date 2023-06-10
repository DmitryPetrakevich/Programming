namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumTabControl = new System.Windows.Forms.TabControl();
            this.EnumTabPage = new System.Windows.Forms.TabPage();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.seasonHandleControl1 = new Programming.View.Controls.SeasonHandleControl();
            this.enumerationsControl1 = new Programming.View.Controls.EnumerationsControl();
            this.Classes = new System.Windows.Forms.TabPage();
            this.moviesControl1 = new Programming.View.Controls.MoviesControl();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.RectanglesPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.EnumTabControl.SuspendLayout();
            this.EnumTabPage.SuspendLayout();
            this.Classes.SuspendLayout();
            this.RectanglesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumTabControl
            // 
            this.EnumTabControl.Controls.Add(this.EnumTabPage);
            this.EnumTabControl.Controls.Add(this.Classes);
            this.EnumTabControl.Controls.Add(this.RectanglesPage);
            this.EnumTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumTabControl.Name = "EnumTabControl";
            this.EnumTabControl.SelectedIndex = 0;
            this.EnumTabControl.Size = new System.Drawing.Size(1132, 662);
            this.EnumTabControl.TabIndex = 0;
            // 
            // EnumTabPage
            // 
            this.EnumTabPage.Controls.Add(this.weekdayParsingControl1);
            this.EnumTabPage.Controls.Add(this.seasonHandleControl1);
            this.EnumTabPage.Controls.Add(this.enumerationsControl1);
            this.EnumTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumTabPage.Name = "EnumTabPage";
            this.EnumTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumTabPage.Size = new System.Drawing.Size(1124, 633);
            this.EnumTabPage.TabIndex = 1;
            this.EnumTabPage.Text = "Enums";
            this.EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(3, 276);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(349, 140);
            this.weekdayParsingControl1.TabIndex = 10;
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Location = new System.Drawing.Point(349, 276);
            this.seasonHandleControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(311, 143);
            this.seasonHandleControl1.TabIndex = 9;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(3, 2);
            this.enumerationsControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(1118, 629);
            this.enumerationsControl1.TabIndex = 8;
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.moviesControl1);
            this.Classes.Controls.Add(this.rectanglesControl1);
            this.Classes.Location = new System.Drawing.Point(4, 25);
            this.Classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Classes.Size = new System.Drawing.Size(1124, 633);
            this.Classes.TabIndex = 2;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(403, 5);
            this.moviesControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(251, 346);
            this.moviesControl1.TabIndex = 4;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(11, 6);
            this.rectanglesControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(251, 345);
            this.rectanglesControl1.TabIndex = 3;
            // 
            // RectanglesPage
            // 
            this.RectanglesPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesPage.Location = new System.Drawing.Point(4, 25);
            this.RectanglesPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RectanglesPage.Name = "RectanglesPage";
            this.RectanglesPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RectanglesPage.Size = new System.Drawing.Size(1124, 633);
            this.RectanglesPage.TabIndex = 3;
            this.RectanglesPage.Text = "Rectangles";
            this.RectanglesPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(4, 4);
            this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(1116, 625);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 662);
            this.Controls.Add(this.EnumTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.EnumTabControl.ResumeLayout(false);
            this.EnumTabPage.ResumeLayout(false);
            this.Classes.ResumeLayout(false);
            this.RectanglesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumTabControl;
        private System.Windows.Forms.TabPage EnumTabPage;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.TabPage RectanglesPage;
        private Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private Controls.RectanglesControl rectanglesControl1;
        private Controls.MoviesControl moviesControl1;
        private Controls.EnumerationsControl enumerationsControl1;
        private Controls.SeasonHandleControl seasonHandleControl1;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
    }
}

