namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о времени
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Секунды
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Минуты
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Создает экземпляр класса Time.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Time.
        /// </summary>
        /// <param name="hours">Часы в диапазоне от 0 до 23 включительно.</param>
        /// <param name="minutes">Минуты в диапазоне от 0 до 59 включительно.</param>
        /// <param name="seconds">Секунды в диапазоне от 0 до 59 включительно.</param>
        public Time(int hours, 
                    int minutes, 
                    int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает и задает количество часов в диапазоне от 0 до 23 включительно.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validators.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество минут в диапазоне от 0 до 59 включительно.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validators.AssertValueInRange(value, 0, 59, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество секунд в диапазоне от 0 до 59 включительно.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validators.AssertValueInRange(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}
