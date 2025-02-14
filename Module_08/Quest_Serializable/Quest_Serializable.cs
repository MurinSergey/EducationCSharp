using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module_08.Quest_Serializable
{
    public class Quest_Serializable
    {
        public static void Run()
        {
            //Создаем объект
            Person npc = new() { Name = "NPC", Age = 35 };
            Console.WriteLine("Объект создан");

            //Сериализация
            /*
             * Свойство WriteIndented отвечает за форматирование JSON. 
             * Если оно равно true, то JSON будет выводиться с отступами и переносами строк, что делает его более читаемым. 
             * Если false, то JSON будет выводиться в одну строку без форматирования.
             */
            var option = new JsonSerializerOptions { WriteIndented = true };
            var serializableString = JsonSerializer.Serialize(npc, option);
            File.WriteAllText("jsonPerson.json", serializableString);
            Console.WriteLine("Объект успешно сохранен");

            //Десериализация
            var deserializableString = File.ReadAllText("jsonPerson.json");
            Person? newNPC = JsonSerializer.Deserialize<Person>(deserializableString);
            if (newNPC is not null)
            {
                Console.WriteLine("Объект успешно воссоздан");
                Console.WriteLine($"Имя: {newNPC.Name} Возраст: {newNPC.Age}");
            }
        }


        /// <summary>
        /// Класс пример для сериализации
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        [Serializable]
        public class Person
        {
            public string? Name { get; set; } = default;
            public int Age { get; set; } = default;
        }


    }
}
