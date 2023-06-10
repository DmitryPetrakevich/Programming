namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о учебной дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _countOfHour;

        /// <summary>
        /// Оценка.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Создает экземпляр класса Subject.
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Subject.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="countOfHour">Количество часов. Положительное число.</param>
        /// <param name="mark">Оценка в диапазоне от 1 до 5 включительно.</param>
        public Subject(string name,
                       int countOfHour, 
                       int mark)
        {
            Name = name;
            CountOfHour = countOfHour;
            Mark = mark;
        }

        /// <summary>
        /// Возвращает и задает количество часов. Положительное число.
        /// </summary>
        public int CountOfHour
        {
            get
            {
                return _countOfHour;
            }
            set
            {
                Validators.AssertOnPositiveValue((int)value, nameof(CountOfHour));
                _countOfHour = value;
            }
        }

        /// <summary>
        /// Возвращает и задает оценку в диапазоне от 1 до 5 включительно.
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validators.AssertValueInRange(value, 1, 5, nameof(Mark));
                _mark = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        private string Name { get; set; }
    }
}
