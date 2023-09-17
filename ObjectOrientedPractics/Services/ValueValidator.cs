using System;

/// <summary>
/// Сервисный класс для валидации значений.
/// </summary>
public class ValueValidator
{
    /// <summary>
    /// Проверяет, что тсрока не превышает максимальную длинну.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="maxLength">Максимальная длина строки.</param>
    /// <param name="propertyName">Имя свойста, в котором вызван метод.</param>
    /// exception cref="ArgumentException">Выбрасывется, если строка длинее заданной максимальной длины.</exception>
    public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength)
        {
            throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
        }
    }
}
