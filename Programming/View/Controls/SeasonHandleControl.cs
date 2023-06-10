using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по выводу MessageBox.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса SeasonHandleControl.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();
            foreach (Season value in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(value);
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedIndex == -1) return;
            var season = Enum.Parse(typeof(Season), SeasonComboBox.Text, true);
            switch (season)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр, Морозяка какая");
                    break;
                case Season.Spring:
                    SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура, солнце!");
                    break;
                case Season.Autumn:
                    SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}
