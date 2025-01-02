using System;

namespace Module_07.Quest_755;

public class Obj
{
    public string Name;
    public string Description;

    public static string Parent;
    public static int DaysInWeek;
    public static int MaxValue;

    static Obj(){
        Parent = "System.Object";
        DaysInWeek = 7;
        MaxValue = 2000;
    }
}
