using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="EnumerationControl"/>.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();

            foreach (Enums value in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(value);
            }
            EnumsListBox.SelectedIndex = 0;

        }
        
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            Array enumValues;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.FormOfStudy:
                    enumValues = Enum.GetValues(typeof(FormOfStudy));
                    break;
                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufacture:
                    enumValues = Enum.GetValues(typeof(Manufacture));
                    break;
                case Enums.Season:
                    enumValues = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in enumValues)
            {
                ValueListBox.Items.Add(value);
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ((int)(ValueListBox.SelectedItem)).ToString();
        }
    }
}
