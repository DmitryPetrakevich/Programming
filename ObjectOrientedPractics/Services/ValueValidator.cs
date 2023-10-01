using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для валидации данных.
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Проверяет, что строка не превышает определённое кол-во символов.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальное количество допустимых символов.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length >= maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов", propertyName);
            }
        }

        /// <summary>
        /// Проверяет, что число не выходит из диапазона.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Минимально допустимое число.</param>
        /// <param name="max">Максимально допустимое число.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertDoubleOnRange(double value, double min, double max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{propertyName} должен быть больше {min} и меньше {max}", propertyName);
            }
        }
    }
}
