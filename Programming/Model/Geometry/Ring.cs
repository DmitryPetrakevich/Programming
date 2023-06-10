using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создает экземпляр класса Ring.
        /// </summary>
        /// <param name="center">Координаты цетра кольца.</param>
        /// <param name="outerRadius">Внешний радиус. Положительное число и больше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус. Положительное число и меньше внешнего радиуса.</param>
        public Ring(Point2D center,
                    double outerRadius,
                    double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

        }

        /// <summary>
        /// Возвращает и задает координаты центра кольца. 
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Внешний радиус. Положительное число и больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validators.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validators.AssertValueInRange(value, _innerRadius, double.MaxValue, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Внутренний радиус. Положительное число и меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validators.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validators.AssertValueInRange(value, 0, _outerRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}
