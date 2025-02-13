using System;

namespace Module_08.Quest_814;

public class Folder
{

    /// <summary>
    /// ��������� �������� �������������
    /// </summary>
    public Dictionary<string, Folder> Folders = [];

    /// <summary>
    /// ��������� ������ � ����������
    /// </summary>
    public List<string> Files { get; set; } = [];

    /// <summary>
    /// ������ ��� ������� ����������
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// ����������� ����� ���������
    /// </summary>
    /// <param name="name"></param>
    public Folder(string name){
        Name = name;
    }

    /// <summary>
    /// ����� ������� ����� �������������
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
    /// ����� ��������� ��� ����� � ��������� ������
    /// </summary>
    /// <param name="name"></param>
    public void AddFile(string name){
        if(!Files.Contains(name)){
            Files.Add(name);
        }
    }


}
