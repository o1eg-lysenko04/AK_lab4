using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = "C:\\Users\\1\\Desktop";

        int fileCount = CountFilesInDirectory(directoryPath);

        Console.WriteLine("Количество файлов в каталоге: " + fileCount);
    }

    static int CountFilesInDirectory(string directoryPath)
    {
        int count = 0;

        // Получаем список файлов в текущем каталоге
        string[] files = Directory.GetFiles(directoryPath);

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
