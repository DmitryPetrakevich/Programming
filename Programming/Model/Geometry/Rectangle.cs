namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит свойства прямоугольника.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectaglesCount;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Id прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        public Rectangle()
        {
            _allRectaglesCount++;
            _id = _allRectaglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        /// <param name="height">Длина прямоугольника. Положительное число.</param>
        /// <param name="width">Ширина прямоугольника. Положительное число.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
        public Rectangle(int height, 
                         int width, 
                         string color, 
                         Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectaglesCount++;
            _id = _allRectaglesCount;
        }

        /// <summary>
        /// Возвращает и задает Id прямоугольника.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Положительное число.
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validators.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Положительное число.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validators.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество прямоугольников. Положительное число.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectaglesCount;
            }
        }

        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }
    }
}
