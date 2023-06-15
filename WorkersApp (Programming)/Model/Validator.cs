namespace WorkersApp__Programming_.Model;

using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

/// <summary>
/// Сервисный класс, хранящий методы валидации значений переменных.
/// </summary>
public static class Validator
{
    //TODO: поменять местами min-max
    /// <summary>
    /// Проверяет числовое значение на принадлежность промежутку.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="max">Верхняя граница промежутка.</param>
    /// <param name="min">Нижняя граница промежутка.</param>
    /// <exception cref="ArgumentException">Выдает сообщение об ошибке, если
    /// значение не принадлежит промежутку.</exception>
    public static void AssertValueOnRange(int value, int max, int min)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException(
                $"The value of the {nameof(value)} " +
                $"don't belongs the interval from " +
                $"{nameof(min)} to {nameof(max)}.");
        }
    }

    /// <summary>
    /// Проверяет строку на наличие символов, не принадлежащих английскому алфавиту.
    /// </summary>
    /// <param name="propertyName">Проверяемая строка.</param>
    /// <exception cref="ArgumentException">Выдает сообщение об ошибке
    /// при наличии недопустимых символов.</exception>
    public static void AssertValueOnCorrectLetters([CallerMemberName] string propertyName = "")
    {
        if (!Regex.IsMatch(propertyName, "^[a-zA-Z ]*$"))
        {
            throw new ArgumentException(
                $"It can be only English alphabet characters in {propertyName}.");
        }
    }

    /// <summary>
    /// Проверяет строку на максимальное количество символов.
    /// </summary>
    /// <param name="maxLength">Максимальная длина строки.</param>
    /// <param name="propertyName">Проверяемая строка.</param>
    /// <exception cref="ArgumentException">Выдает сообщение об ошибке при превышении
    /// максимально возможного числа символов в строке.</exception>
    public static void AssertValueOnCorrectLength(int maxLength,[CallerMemberName] string propertyName = "")
    {
        if (propertyName.Length > maxLength)
        {
            throw new ArgumentException(
                $"The length of the string can't be higher than {nameof(maxLength)}.");
        }
    }

    /// <summary>
    /// Проверяет пустые строки.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <exception cref="ArgumentException">Выдает сообщение об ошибке,
    /// если строка пустая.</exception>
    public static void AssertOnEmptyField(string value)
    {
        if (value == "")
        {
            throw new ArgumentException(
                $"The field of {nameof(value)} is null or empty.");
        }
    }
}