using System;

namespace Module_08.Quest_814;

public class Drive(string name, long space, long emptySpace) //Использовал предложение IDE, которая переделелал конструктор
{
    /// <summary>
    /// Тип диска или директории
    /// </summary>
    internal enum DriveType{
        USB,
        HDD,
        CD
    }

    /// <summary>
    /// Получение имени диска
    /// </summary>
    public string Name { get; } = name;

    /// <summary>
    /// Получение общего объема диска
    /// </summary>
    public long Space { get; } = space;

    /// <summary>
    /// Получение свободного пространства
    /// </summary>
    public long EmptySpace { get; } = emptySpace;

    /// <summary>
    /// Список директорий на диске
    /// </summary>
    public Dictionary<string, Folder> folders { get; } = [];

    /// <summary>
    /// Метод для добавления директрий
    /// </summary>
    /// <param name="name"></param>
    public void AddFolder (string name){
        folders.Add(name, new Folder(name));
    }
}

/// <summary>
/// Статичный класс для описания методов перечисления DriveType класса Module_08.Quest_814.Drive
/// </summary>
public static class DriveTypeMethod
{
    /// <summary>
    /// Метод возвращает текстовое писание выбранного типа носителя
    /// </summary>
    /// <param name="type"></param>
    /// <returns>
    /// Описание выбранного типа на русском языке
    /// </returns>
    /// <exception cref="NotImplementedException"></exception>
    internal static string ToRussianString(this Drive.DriveType type)
    {
        return type switch
        {
            Drive.DriveType.USB => "Тип носителя: Переносной носитель USB",
            Drive.DriveType.HDD => "Тип носителя: Жесткий диск HDD",
            Drive.DriveType.CD => "Тип носителя: CD/DVD-диск",
            _ => throw new NotImplementedException()
        };
    }
}
