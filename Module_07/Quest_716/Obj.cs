using System;

namespace Module_07.Quest_716;

public class Obj
{
    private string name;
    private string owner;
    private int length;
    private int count;

    public Obj(string name, string ownerName, int objLength, int count){
        this.name = name;
        owner = ownerName;
        length = objLength;
        this.count = count;
    }
}
