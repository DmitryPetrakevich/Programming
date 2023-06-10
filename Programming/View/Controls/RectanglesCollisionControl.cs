using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Geometry;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {

        /// <summary>
        /// Коллекция прямоугольников для отображения.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает экземпляр класса RectangleCollisionControl.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод обновления информации в RectangleListBox.
        /// </summary>
        /// <param name="rectangle">Прямоугольник</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = RectangleListBox.FindString(rectangle.Id.ToString());
            if (index == -1) return;

            RectangleListBox.Items[index] = GetRectangleInfo(rectangle);
        }

        /// <summary>
        /// Метож, возвращающий строки со значениями прямоугольника.
        /// </summary>

        private string GetRectangleInfo(Rectangle rectangle)
        {
            return $"{rectangle.Id}. " +
                   $"(X = {rectangle.Center.X} ; " +
                   $"Y = {rectangle.Center.Y} ; " +
                   $"W = {rectangle.Width} ; " +
                   $"H = {rectangle.Height})";
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;
            try
            {
                string rectangleCurrentY = YTextBox.Text;
                int rectangleY = int.Parse(rectangleCurrentY);
                _currentRectangle.Center.Y = rectangleY;
                YTextBox.BackColor = AppColors.CorrectColor;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Location =
                new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                YTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;
            try
            {
                string rectangleCurrentHeight = HeightRectangleTextBox.Text;
                int rectangleHeight = int.Parse(rectangleCurrentHeight);
                _currentRectangle.Height = rectangleHeight;
                HeightRectangleTextBox.BackColor = AppColors.CorrectColor;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightRectangleTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;
            try
            {
                string rectangleCurrentWidth = WidthRectangleTextBox.Text;
                int rectangleWidth = int.Parse(rectangleCurrentWidth);
                _currentRectangle.Width = rectangleWidth;
                WidthRectangleTextBox.BackColor = AppColors.CorrectColor;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthRectangleTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;
            try
            {
                string rectangleCurrentX = XTextBox.Text;
                int rectangleX = int.Parse(rectangleCurrentX);
                _currentRectangle.Center.X = rectangleX;
                XTextBox.BackColor = AppColors.CorrectColor;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);

            }
            catch
            {
                XTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem != null)
            {
                int selectedIndexRectangleListBox = RectangleListBox.SelectedIndex;
                _currentRectangle = _rectangles[selectedIndexRectangleListBox];
                HeightRectangleTextBox.Text = _currentRectangle.Height.ToString();
                WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
                YTextBox.Text = _currentRectangle.Center.Y.ToString();
                XTextBox.Text = _currentRectangle.Center.X.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }

        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectangleListBox.SelectedIndex;
            if (indexSelectedRectangle != -1)
            {
                _rectangles.RemoveAt(indexSelectedRectangle);
                _rectanglePanels.RemoveAt(indexSelectedRectangle);
                CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectangleListBox.Items.Add(GetRectangleInfo(_rectangles[i]));
                    RectangleListBox.SelectedIndex = 0;

                }
                FindCollisions();
            }
        }

        private void RemoveRectangleButton_ButtonEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_ButtonLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(_currentRectangle);
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.IsNotCollision;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            
            RectangleListBox.Items.Add(GetRectangleInfo(_currentRectangle));
            FindCollisions();
        }

        private void AddRectangleButton_ButtonEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_ButtonLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        /// <summary>
        /// Метод нахождения коллизии между прямоугольниками и их перекрашивания.
        /// </summary>
        private void FindCollisions()
        {
            CanvasPanel.SuspendLayout();
            for (int i = 0; i < _rectangles.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = AppColors.IsNotCollision;
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i == j) continue;
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.IsCollision;
                        CanvasPanel.Controls[j].BackColor = AppColors.IsCollision;
                    }
                }
            }
            CanvasPanel.ResumeLayout();
        }

        

        /// <summary>
        /// Метод очищения RectangleListBox и текстовых полей.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectangleListBox.Items.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthRectangleTextBox.Clear();
            IdTextBox.Clear();
            HeightRectangleTextBox.Clear();
        }
    }
}
