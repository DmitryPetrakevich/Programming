namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Продолжительность полета в минутах.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        /// <param name="pointOfDeparture">Пункт отправления.</param>
        /// <param name="pointOfDestination">Пункт назначения.</param>
        /// <param name="flightTime">Продолжительность полета в минутах. Должно быть больше 0.</param>
        public Flight(string pointOfDeparture, 
                      string pointOfDestination, 
                      int flightTime)
        {
            PointOfDeparture = pointOfDeparture;
            PointOfDestination = pointOfDestination;
            FlightTime = flightTime;
        }

        /// <summary>
        /// Возвращает и задает время полета в минутах. Должно быть больше 0.
        /// </summary>
        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validators.AssertOnPositiveValue((int)value, nameof(FlightTime));
                _flightTime = value;
            }
        }

        /// <summary>
        /// Возвращает и задает пункт отправления.
        /// </summary>
        private string PointOfDeparture { get; set; }

        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        private string PointOfDestination { get; set; }
    }
}
