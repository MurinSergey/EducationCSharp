using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module_08.Quest_843
{
    public class Quest_843
    {
        public static void Run()
        {
            //Создаем объект
            Contact contact = new()
            {
                Name = "User",
                Email = "User@vk.com",
                PhoneNumber = 123456789
            };
            Contact contact1 = new()
            {
                Name = "User01",
                Email = "User01@vk.com",
                PhoneNumber = 987654321
            };
            Console.WriteLine("Объект создан");

            //var option = new JsonSerializerOptions { WriteIndented = true };
            //var jsonString = JsonSerializer.Serialize(contact, option);
            //using BinaryWriter writer = new(File.Open("jsonBinary.bin", FileMode.Create, FileAccess.Write));
            //writer.Write(jsonString);
            //Console.WriteLine("Объект сохранен");
            contact.SaveBinaryJson("jsonBinary.bin");
            Contact newContact = Contact.LoadBinaryJson("jsonBinary.bin");
            Console.WriteLine($"{newContact.Name} {newContact.Email} {newContact.PhoneNumber}");

            contact1.SaveBinary("binary.bin");
            Contact newContact1 = Contact.LoadBinary("binary.bin");
            Console.WriteLine($"{newContact1.Name} {newContact1.Email} {newContact1.PhoneNumber}");
        }
    }
}
