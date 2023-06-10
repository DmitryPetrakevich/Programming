namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит координаты прямоугольника.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата Х.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создает экземпляр класса Point2D.
        /// </summary>
        /// <param name="x">Координата Х. Положительное число.</param>
        /// <param name="y">Координата Y. Положительное число.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задает координату Х. Положительное число.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validators.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Y. Положительное число.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validators.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }
    }
}
