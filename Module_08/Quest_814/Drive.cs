using System;

namespace Module_08.Quest_814;

public class Drive(string name, long space, long emptySpace) //Использовал предложение IDE, которая переделелал конструктор
{
    public string Name { get; } = name;
    public long Space { get; } = space;
    public long EmptySpace { get; } = emptySpace;
    public Dictionary<string, Folder> folders { get; } = [];

    public void AddFolder (string name){
        folders.Add(name, new Folder());
    }
}
