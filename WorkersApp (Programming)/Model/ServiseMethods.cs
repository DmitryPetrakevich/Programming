namespace WorkersApp__Programming_.Model;

/// <summary>
/// Сервисный класс, содержащий методы работы со
/// списками.
/// </summary>
public static class ServiseMethods
{
    //TODO: Переименовать
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

    /// <summary>
    /// Получает путь до рабочего json-файла программы.
    /// </summary>
    /// <returns>Возвращает путь до рабочего файла программы.</returns>
    public static string GetPath()
    {
        var getSystemPath = GetPathToFolder();

        return $"{getSystemPath}\\Workers.json";
    }

    /// <summary>
    /// Получает путь до рабочей папки программы
    /// </summary>
    /// <returns>Возвращает путь к рабочей папки программы.</returns>
    public static string GetPathToFolder()
    {
        var getSystemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        return $"{getSystemPath}\\WorkersDirectory";
    }

    /// <summary>
    /// Создает папку в рабочей директории программы.
    /// </summary>
    public static void CreateDirectory()
    {
        var getSystemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        Directory.CreateDirectory($"{getSystemPath}\\WorkersDirectory");
    }
}