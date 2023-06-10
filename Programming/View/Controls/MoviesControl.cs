using System;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int CountElements = 5;

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Поле рандом.
        /// </summary>
        private Random _randomValues;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            
            InitializeComponent();
            _randomValues = new Random();
            _movies = CreateMovies();
            

        }

        /// <summary>
        /// Метод нахождения фильма с максимальным рейтингом.
        /// </summary>
        /// <param name="movies"></param>
        /// <returns>Возвращает индекс фильма с максимальным рейтигом</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            double maxRating = movies[0].Rating;
            int maxRatingIndex = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void NameOfMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = NameOfMovieTextBox.Text;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(RatingTextBox.Text);
                RatingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void YearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = int.Parse(YearOfReleaseTextBox.Text);
                YearOfReleaseTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                YearOfReleaseTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
                DurationTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                DurationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int movieSelectIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[movieSelectIndex];
            GenreTextBox.Text = _currentMovie.Genre;
            NameOfMovieTextBox.Text = _currentMovie.Name;
            YearOfReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            DurationTextBox.Text = _currentMovie.Duration.ToString();
        }
        /// <summary>
        /// Инициализирует массив фильмов.
        /// </summary>
        /// <returns>Возращает массив фильмов.</returns>
        private Movie[] CreateMovies()
        {
            Movie[] movies = new Movie[CountElements];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < CountElements; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _randomValues.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _randomValues.Next(1900, 2023);
                _currentMovie.Genre = genres.GetValue(_randomValues.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.Duration = _randomValues.Next(1, 151);
                movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            return movies;
        }
    }
}
