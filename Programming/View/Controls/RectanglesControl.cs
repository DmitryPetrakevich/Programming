using System;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Geometry;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников в ListBox.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Константа количества элементов.
        /// </summary>
        private const int CountElements = 5;

        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создается экземпляр класса RectanglesControl.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            _rectangles = CreateRectangles();
        }

        /// <summary>
        /// Метод инициализации прямоугольников.
        /// </summary>
        /// <returns> Массив прямоугольников.</returns>
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[CountElements];
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rectangleSelectIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[rectangleSelectIndex];
            HeightRectanglesTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(HeightRectanglesTextBox.Text);
                HeightRectanglesTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                HeightRectanglesTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindRectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Метод нахождения прямоугольников с максимальной шириной.
        /// </summary>
        /// <param name="rectangles">Прямоугольник.</param>
        /// <returns>Индекс прямоугольника с максимальной шириной.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double maxWidth = rectangles[0].Width;
            int maxWidthIndex = 0;
            for (int i = 0; i < CountElements; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }
    }
}
