using System;

namespace Module_09.Quest_Final;

public class Main
{
    public static void Run(){
        Action startProgram = First_Quest.Main.Run;
        startProgram += Second_Quest.Main.Run;
        startProgram?.Invoke();
        Console.ReadKey();
    }
}
