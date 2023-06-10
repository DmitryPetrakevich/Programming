using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Создает экземпляр класса Movie.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Movie.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма в минутах. Должно быть больше 0.</param>
        /// <param name="releaseYear">Год выпуска фильма от 1900 до нынешнего года.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма от 0.0 до 10.0.</param>
        public Movie(string name, 
                    int duration, 
                    int releaseYear, 
                    string genre, 
                    double rating)
        {
            Name = name;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах. Должно быть больше 0.
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
        /// Возвращает и задает год выпуска фильма. Должен быть в диапазоне от 1900 до нынешнего года.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validators.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Диапазон от 0.0 до 10.0.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validators.AssertValueInRange(value, 0.0, 10.0, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }
    }
}
