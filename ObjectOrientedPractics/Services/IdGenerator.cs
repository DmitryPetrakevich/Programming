using System;

/// <summary>
/// Класс для генерации уникальных идкетификаторов.
/// </summary>
public class IdGenerator
{
    private static int _nextId = 1;

    /// <summary>
    /// Получает следующий уникальный идентификатор.
    /// </summary>
    /// <returns>Уникальный идентификатор.</returns>
    public static int GetNextId()
    {
        return _nextId++;
    }
}
