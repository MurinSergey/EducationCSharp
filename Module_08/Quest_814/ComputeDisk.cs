using System;

namespace Module_08.Quest_814;

public class ComputeDisk
{
    public string Name { get; }
    public long Space { get; }
    public long EmptySpace { get; }
    public Dictionary<string, Folder> folders { get; } = [];
    public ComputeDisk(string name, long space, long emptySpace){
        Name = name;
        Space = space;
        EmptySpace = emptySpace;
    }

    public void AddFolder (string name){
        folders.Add(name, new Folder());
    }
}
