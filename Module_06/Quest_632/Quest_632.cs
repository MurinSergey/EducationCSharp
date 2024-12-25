using System;

namespace Module_06.Quest_632;

public class Quest_632
{

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue && Load > 0){
                Console.WriteLine($"В автобусе {Load.Value} пассажиров");
            } else {
                Console.WriteLine("Автобус пуст");
            }
        }
    }
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается задание 6.3.2===");
    }
}
