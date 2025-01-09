using System;

namespace Module_08.Quest_814;

public class ComputeDisk
{
    public string Name { get; }
    public double Space { get; }
    public double EmptySpace { get; }
    public ComputeDisk(string name, double space, double emptySpace){
        Name = name;
        Space = space;
        EmptySpace = emptySpace;
    }
}
