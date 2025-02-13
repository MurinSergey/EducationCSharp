using System;

namespace Module_08.Quest_814;

public class Folder
{

    /// <summary>
    /// Коллекция хранящая поддиректории
    /// </summary>
    public Dictionary<string, Folder> Folders = [];

    /// <summary>
    /// Коллекция файлов в директории
    /// </summary>
    public List<string> Files { get; set; } = [];

    /// <summary>
    /// Хранит имя текущей директории
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Конструктор новой директрии
    /// </summary>
    /// <param name="name"></param>
    public Folder(string name){
        Name = name;
    }

    /// <summary>
    /// Метод создает новую поддиректорию
    /// </summary>
    /// <param name="name"></param>
    public void AddFolder(string name)
    {
        if (!Folders.ContainsKey(name))
        {
            Folders.Add(name, new Folder(name));
        }
    }

    /// <summary>
    /// Метод добавляем имя файла в коллекцию файлов
    /// </summary>
    /// <param name="name"></param>
    public void AddFile(string name){
        if(!Files.Contains(name)){
            Files.Add(name);
        }
    }


}
