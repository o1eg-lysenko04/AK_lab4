using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = "путь_к_каталогу";

        int fileCount = CountFilesInDirectory(directoryPath);

        Console.WriteLine("Количество файлов в каталоге: " + fileCount);
    }

    static int CountFilesInDirectory(string directoryPath)
    {
        int count = 0;

        // Получаем список файлов в текущем каталоге
        string[] files = Directory.GetFiles(directoryPath);

        // Увеличиваем счетчик на количество файлов в текущем каталоге
        count += files.Length;

        // Рекурсивно обходим все подкаталоги
        string[] subdirectories = Directory.GetDirectories(directoryPath);
        foreach (string subdirectory in subdirectories)
        {
            count += CountFilesInDirectory(subdirectory);
        }

        return count;
    }
}
