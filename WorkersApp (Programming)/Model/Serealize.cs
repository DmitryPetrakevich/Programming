using System;
namespace WorkersApp__Programming_.Model;

public static class Serealize
{
	{
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
}
