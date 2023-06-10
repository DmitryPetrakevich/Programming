using System;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Enums;
namespace Programming.Model.Geometry
{
    /// <summary>
    /// Предоставляет реализацию по созданию прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Случайное значение.
        /// </summary>
        private static Random _random;

        /// <summary>
        /// Создает экземпляр класса RectangleFactory.
        /// </summary>
        static RectangleFactory()
        {
            _random = new Random();
        }

        /// <summary>
        /// Создает прямоугольник со случайными координатами, шириной, высотой.
        /// </summary>
        /// <param name="widthCanvas">Ширина панели, на которой размещаются прямоугольники.</param>
        /// <param name="heightCanvas">Высота панели, на которой размещаются прямоугольники.</param>
        /// <returns>Возвращает прямоугольник со случайными значениями.</returns>
        public static Rectangle Randomize(int widthCanvas, int heightCanvas)
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin), 
                                           _random.Next(Margin, heightCanvas - rectangle.Height - Margin));
            
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }

        /// <summary>
        /// Создает прямоугольник со случайными координатами, шириной, высотой.
        /// </summary>
        /// <returns>Возвращает прямоугольник со случайными значениями.</returns>
        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(1, 500), _random.Next(1, 500));
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}
