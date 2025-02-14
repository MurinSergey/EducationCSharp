using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08.Quest_BinaryStream
{
    public class BinaryStream
    {
        const string SettingsFileName = "Settings.cfg";

        public static void Run()
        {
            FileInfo file = new(SettingsFileName);
            WriteValues(file);
            ReadValue(file);
        }

        /// <summary>
        /// Метод записывает тестовые данные в переданный файл
        /// </summary>
        /// <param name="file"></param>
        static void WriteValues(FileInfo file)
        {
            //Создаем объект BinaryWrite и указываем, куда будет направлен поток данных
            using BinaryWriter writer = new(file.Open(FileMode.Create));
            //Записываем данные
            writer.Write(20.666F);
            writer.Write("Тестовая строка");
            writer.Write(55);
            writer.Write(false);
        }

        /// <summary>
        /// Метод выводит содержимое переданного файла
        /// </summary>
        /// <param name="file"></param>
        static void ReadValue(FileInfo file)
        {
            float TestFloatValue;
            string TestStringValue;
            int TestIntValue;
            bool TestBooleanValue;

            if (file.Exists)
            {
                // Создаем объект BinaryReader
                using BinaryReader reader = new(file.Open(FileMode.Open));
                TestFloatValue = reader.ReadSingle();
                TestStringValue = reader.ReadString();
                TestIntValue = reader.ReadInt32();
                TestBooleanValue = reader.ReadBoolean();

                Console.WriteLine("Из файла прочитано:");
                Console.WriteLine($"Дробь: {TestFloatValue}");
                Console.WriteLine($"Строка: {TestStringValue}");
                Console.WriteLine($"Целое: {TestIntValue}");
                Console.WriteLine($"Булевое значение: {TestBooleanValue}");
            }
        }
    }
}
