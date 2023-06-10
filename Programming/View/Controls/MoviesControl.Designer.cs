namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.YearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.YearOfReleaseLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.NameOfMovieLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.NameOfMovieTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.FindMovieButton);
            this.MovieGroupBox.Controls.Add(this.DurationTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationLabel);
            this.MovieGroupBox.Controls.Add(this.YearOfReleaseTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.YearOfReleaseLabel);
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingLabel);
            this.MovieGroupBox.Controls.Add(this.NameOfMovieLabel);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Controls.Add(this.NameOfMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Location = new System.Drawing.Point(2, 2);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.MovieGroupBox.Size = new System.Drawing.Size(181, 275);
            this.MovieGroupBox.TabIndex = 3;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(101, 249);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(76, 19);
            this.FindMovieButton.TabIndex = 10;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(101, 180);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(76, 20);
            this.DurationTextBox.TabIndex = 9;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(98, 163);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(50, 13);
            this.DurationLabel.TabIndex = 4;
            this.DurationLabel.Text = "Duration:";
            // 
            // YearOfReleaseTextBox
            // 
            this.YearOfReleaseTextBox.Location = new System.Drawing.Point(101, 141);
            this.YearOfReleaseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YearOfReleaseTextBox.Name = "YearOfReleaseTextBox";
            this.YearOfReleaseTextBox.Size = new System.Drawing.Size(76, 20);
            this.YearOfReleaseTextBox.TabIndex = 8;
            this.YearOfReleaseTextBox.TextChanged += new System.EventHandler(this.YearOfReleaseTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(101, 105);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(76, 20);
            this.RatingTextBox.TabIndex = 6;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // YearOfReleaseLabel
            // 
            this.YearOfReleaseLabel.AutoSize = true;
            this.YearOfReleaseLabel.Location = new System.Drawing.Point(98, 126);
            this.YearOfReleaseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            this.YearOfReleaseLabel.Size = new System.Drawing.Size(71, 13);
            this.YearOfReleaseLabel.TabIndex = 3;
            this.YearOfReleaseLabel.Text = "ReleaseYear:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(101, 69);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(76, 20);
            this.GenreTextBox.TabIndex = 7;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(98, 89);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 4;
            this.RatingLabel.Text = "Rating:";
            // 
            // NameOfMovieLabel
            // 
            this.NameOfMovieLabel.AutoSize = true;
            this.NameOfMovieLabel.Location = new System.Drawing.Point(98, 18);
            this.NameOfMovieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameOfMovieLabel.Name = "NameOfMovieLabel";
            this.NameOfMovieLabel.Size = new System.Drawing.Size(38, 13);
            this.NameOfMovieLabel.TabIndex = 1;
            this.NameOfMovieLabel.Text = "Name:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(5, 18);
            this.MovieListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(92, 251);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // NameOfMovieTextBox
            // 
            this.NameOfMovieTextBox.Location = new System.Drawing.Point(101, 33);
            this.NameOfMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameOfMovieTextBox.Name = "NameOfMovieTextBox";
            this.NameOfMovieTextBox.Size = new System.Drawing.Size(76, 20);
            this.NameOfMovieTextBox.TabIndex = 5;
            this.NameOfMovieTextBox.TextChanged += new System.EventHandler(this.NameOfMovieTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(98, 54);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre:";
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(188, 281);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox YearOfReleaseTextBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label YearOfReleaseLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label NameOfMovieLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.TextBox NameOfMovieTextBox;
        private System.Windows.Forms.Label GenreLabel;
    }
}
