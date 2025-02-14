using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module_08.Quest_843
{
    [Serializable]
    public class Contact
    {
        public string? Name { get; set; } = default;
        public long PhoneNumber { get; set; } = default;
        public string? Email { get; set; } = default;

        private readonly JsonSerializerOptions option = new() { WriteIndented = true };


        /// <summary>
        /// Метод сохраняет текущий класс в JSON в бинарном виде
        /// </summary>
        /// <param name="path"></param>
        public void SaveBinaryJson(string path)
        {
            var jsonString = JsonSerializer.Serialize(this, option);
            using BinaryWriter writer = new(File.Open(path, FileMode.Create, FileAccess.Write));
            writer.Write(jsonString);
        }

        /// <summary>
        /// Загружает класс из бинарного файла переводя его из JSON
        /// </summary>
        /// <param name="path"></param>
        /// <returns>
        /// Восстановленый объект
        /// </returns>
        public static Contact LoadBinaryJson(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using BinaryReader reader = new(File.Open(path, FileMode.Open, FileAccess.Read));
                    StringBuilder stringBuilder = new();
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        stringBuilder.Append(reader.ReadString());
                    }
                    string str = stringBuilder.ToString();
                    return JsonSerializer.Deserialize<Contact>(str) ?? new Contact();
                }
                else
                {
                    return new Contact();
                }
            }
            catch (Exception e)
            {
                return new Contact();
            }
        }

        /// <summary>
        /// Сохраняет класс в бинарном формате
        /// </summary>
        /// <param name="path"></param>
        public void SaveBinary(string path)
        {
            using BinaryWriter writer = new(File.Open(path, FileMode.Create, FileAccess.Write));
            writer.Write(Name);
            writer.Write(PhoneNumber);
            writer.Write(Email);
        }

        /// <summary>
        /// Восстанавливает класс из бинарного файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Contact LoadBinary(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using BinaryReader reader = new(File.Open(path, FileMode.Open, FileAccess.Read));
                    var res = new Contact()
                    {
                        Name = reader.ReadString(),
                        PhoneNumber = reader.ReadInt64(),
                        Email = reader.ReadString()
                    };
                    return res;
                }
                else
                {
                    Console.WriteLine("Нет файла");
                    return new Contact();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Contact();
            }
        }
    }
}
