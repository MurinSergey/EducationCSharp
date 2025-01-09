using System;

namespace Module_08.Quest_814;

public class Folder
{
    string Name { get; set; }
    public Folder(string name){
        Name = name;
    }

    public List<string> Files { get; } = [];
    public void AddFile(string name){
        if(!Files.Contains(name)){
            Files.Add(name);
        }
    }
}
