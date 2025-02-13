using System;

namespace Module_08.Quest_Files;

public class Example
{
    public static void Run()
    {
        string homePathUbuntu = "/home/murin/Students.txt";
        if (!File.Exists(homePathUbuntu))
        {
            //Если не существует, то создаем файл и наполняем его
            using (var writeFile = File.CreateText(homePathUbuntu))
            {
                writeFile.WriteLine("Сергей");
                writeFile.WriteLine("Роман");
                writeFile.WriteLine("Антон");
            }

            //Открываем файл и выводим содержимое в консоль
            using (var readFile = File.OpenText(homePathUbuntu)){
                string? text = "";
                //Пока результат считывания не равен null считываем и выводим данные в консоль
                while((text = readFile.ReadLine()) != null){
                    Console.WriteLine(text);
                }
            }
        }
    }
}
