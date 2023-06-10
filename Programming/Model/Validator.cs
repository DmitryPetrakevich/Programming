using System;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для валидации входныз данных.
    /// </summary>
    public static class Validators
    {
        /// <summary>
        /// Проверяет целочисленные входные данные на положительное значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string nameProperty)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameProperty} must be positive");
            }
        }

        /// <summary>
        /// Проверяет вещественные входные данные на положительное значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, string nameProperty)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameProperty} must be positive");
            }
        }

        /// <summary>
        /// Проверяет целочисленное входное значение на то, входит ли оно в определенный диапазон.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Минимальная граница диапазона.</param>
        /// <param name="max">Максимальная граница диапазона.</param>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string nameProperty)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }

        /// <summary>
        /// Проверяет вещественное входное значение на то, входит ли оно в определенный диапазон.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Минимальная граница диапазона.</param>
        /// <param name="max">Максимальная граница диапазона.</param>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, double min, double max, string nameProperty)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }

        /// <summary>
        /// Проверяет, состоит ли строка только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Входная строка.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!(char.IsLetter(value[i])))
                {
                    throw new ArgumentException($"{propertyName} must contain English letters");
                }
            }
        }
    }
}