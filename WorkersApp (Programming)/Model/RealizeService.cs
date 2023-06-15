namespace WorkersApp__Programming_.Model;

/// <summary>
/// Сервисный класс, содержащий методы работы со
/// списками.
/// </summary>
public static class RealizeService
{
    //TODO: Переименова
    /// <summary>
    /// Создает новый список имен для панели WorkersListBox.
    /// </summary>
    /// <param name="workers">Список работников.</param>
    /// <returns>Возвращает отсортированный в алфавитном порядке
    /// строковый массив имен работников.</returns>
    public static string[] WorkersNames(List<Worker> workers)
    {
        workers.Sort((x, y) => x.FullName.CompareTo(y.FullName));

        string[] names = new string[workers.Count];
        for (int i = 0; i < workers.Count; i++)
        {
            names[i] = workers[i].FullName;
        }

        return names;
    }
}