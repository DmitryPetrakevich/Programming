namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создает экземпляр класса Song.
        /// </summary>
        public Song() 
        {
        }

        /// <summary>
        /// Создает экземпляр класса Song.
        /// </summary>
        /// <param name="name">Название песни</param>
        /// <param name="genre">Жанр песни</param>
        /// <param name="duration">Продолжительность песни в секундах. Должна быть больше 0.</param>
        public Song(string name, 
                    string genre, 
                    int duration)
        {
            Name = name;
            Genre = genre;
            Duration = duration;
        }

        /// <summary>
        /// Возвращает и задает продолжительность песни в секундах. Должно быть больше 0.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validators.AssertOnPositiveValue((int)value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает жанр песни.
        /// </summary>
        public string Genre { get; set; }
    }
}
