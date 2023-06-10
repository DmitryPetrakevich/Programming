using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Осуществляет хранения цветов.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет корректного значения в валидации.
        /// </summary>
        public static Color CorrectColor = Color.White;

        /// <summary>
        /// Цвет некорректного значения в валидации.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет прямоугольников при пересечении.
        /// </summary>
        public static Color IsCollision = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет прямоугольников, которые не пересекаются.
        /// </summary>
        public static Color IsNotCollision = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Синий цвет при выборе Winter в ComboBox.
        /// </summary>
        public static Color Winter = Color.Blue;

        /// <summary>
        /// Голубой цвет при выборе Spring в ComboBox.
        /// </summary>
        public static Color Spring = Color.Cyan;

        /// <summary>
        /// Зеленый цвет при выборе Summer в ComboBox.
        /// </summary>
        public static Color Summer = Color.Green;

        /// <summary>
        /// Оранжевый цвет при выборе Autumn в ComboBox.
        /// </summary>
        public static Color Autumn = Color.Orange;
    }
}
