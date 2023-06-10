using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по парсингу дней недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса WeekdayParsingControl.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string parseText = ParseTextBox.Text;
            Weekday weekday;
            if (Enum.TryParse(parseText, out weekday))
            {
                ParseLabel.Text = $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                ParseLabel.Text = "Такого дня недели нет";
            }
        }
    }
}
