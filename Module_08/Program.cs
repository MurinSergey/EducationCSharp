﻿using Module_08.Quest_814;

namespace Module_08;

class Program
{
    static void Main(string[] args)
    {
        DriveInfo[] drives = PrintDriveInfo();
        (_, _) = PrintAllSubFolderObjects(drives[0].Name);
        (_, _) = PrintAllSubFolderObjects(drives[1].Name);
        CreateFolder(drives[1].Name, "Новая папка");
        (_, _) = PrintAllSubFolderObjects(drives[1].Name);
    }

    /// <summary>
    /// Метод распечатывает в консоль информацию о носителях
    /// </summary>
    /// <returns>
    /// Возвращается список всех носителей
    /// </returns>
    static DriveInfo[] PrintDriveInfo()
    {
        DriveInfo[] drivers = DriveInfo.GetDrives();

        foreach (DriveInfo driver in drivers)
        {
            Console.WriteLine("===================================================");
            Console.WriteLine($"Название: {driver.Name}");
            Console.WriteLine($"Тип: {driver.DriveType}");
            if (driver.IsReady)
            {
                Console.WriteLine($"Объем: {driver.TotalSize}");
                Console.WriteLine($"Свободно: {driver.TotalFreeSpace}");
                Console.WriteLine($"Метка: {driver.VolumeLabel}");
            }
        }

        return drivers;
    }

    /// <summary>
    /// Метод распечатывает информацию о содержимом переданной директории
    /// </summary>
    /// <param name="path"></param>
    /// <returns>
    /// Возвращается кортеж, содержащий списки папок и файлов (Foldes, Files)
    /// </returns>
    /// <exception cref="DirectoryNotFoundException"></exception>
    static (string[], string[]) PrintAllSubFolderObjects(string path)
    {
        string dirName = path;
        if (Directory.Exists(dirName))
        {
            Console.WriteLine("===================================================");
            Console.WriteLine($"Содержимое директории: {dirName}");
            Console.WriteLine("Папки:");
            string[] folders = Directory.GetDirectories(dirName);
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
            }

            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(dirName);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine($"Общее количество папок и файлов: {CalcCountAllSubFolderObjects(dirName)}");

            return (folders, files);
        }
        throw new DirectoryNotFoundException("Директория не существует");
    }

    /// <summary>
    /// Метод считает количество папок и файлов в переданной директории
    /// </summary>
    /// <param name="path"></param>
    /// <returns>
    /// Общее количество папок и файлов
    /// </returns>
    /// <exception cref="DirectoryNotFoundException"></exception>
    static int CalcCountAllSubFolderObjects(string path)
    {
        //string dirName = path;
        //if ( Directory.Exists(dirName) ){
        //    string[] folders = Directory.GetDirectories(dirName);
        //    string[] files = Directory.GetFiles(dirName);
        //    return folders.Length + files.Length;
        //}
        //throw new DirectoryNotFoundException("Директория не существует");

        try
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                return directoryInfo.GetDirectories().Length + directoryInfo.GetFiles().Length;
            }
            else
            {
                throw new DirectoryNotFoundException("Директория не существует");
            }
        }
        catch (Exception e) { 
            Console.WriteLine(e.Message);
            throw new DirectoryNotFoundException("Директория не существует");
        }
    }

    /// <summary>
    /// Создание новой папки
    /// </summary>
    /// <param name="path"></param>
    /// <exception cref="DirectoryNotFoundException"></exception>
    static void CreateFolder(string path, string name)
    {
        try
        {
            DirectoryInfo directoryInfo = new($"{path}/{name}");
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                directoryInfo.CreateSubdirectory("Еще одна новая папка");

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new DirectoryNotFoundException("Директория не существует");
        }
    }
}
