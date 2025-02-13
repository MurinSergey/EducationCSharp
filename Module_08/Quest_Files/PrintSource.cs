using System;

namespace Module_08.Quest_Files;

public class PrintSource
{
    public static void Run()
    {
        string? path = "/home/murin/Education/CSharp/Skillfactory/EducationCSharp/Module_08";
        path = $"{path}/Quest_Files/PrintSource.cs";

        //Открываем файл и выводим содержимое в консоль
        using (var readFile = File.OpenText(path)){
            string? text = "";
            //Пока результат считывания не равен null считываем и выводим данные в консоль
            while((text = readFile.ReadLine()) != null){
                Console.WriteLine(text);
            }
        }
    }
}
