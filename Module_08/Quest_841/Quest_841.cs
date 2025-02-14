using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_08.Quest_841
{
    public class Quest_841
    {
        public static void Run()
        {
            string binaryFile = "C:\\Users\\murin\\Documents\\CodeProjects\\EducationCSharp\\Module_08\\Quest_841\\BinaryFile.bin";
            UpdateBinaryFile(binaryFile);
            ReadBinaryFile(binaryFile);
        }

        /// <summary>
        /// Метод изменяет переданный файл
        /// </summary>
        /// <param name="file"></param>
        public static void UpdateBinaryFile(string file)
        {
            string str = $"Файл был обновлен {DateTime.Now:dd-MM-yyyy HH:mm} на компьютере с ОС {RuntimeInformation.OSDescription}";
            try
            {
                if (File.Exists(file))
                {
                    using BinaryWriter writer = new(File.Open(file, FileMode.Append, FileAccess.Write));
                    writer.Write(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Метод считывает данные из бинарного файла расположенного в ресурсах приложения
        /// </summary>
        /// <param name="bytes"></param>
        public static void ReadBinaryFile(string file)
        {
            try
            {
                using BinaryReader reader = new(File.Open(file, FileMode.Open, FileAccess.Read));
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string str = reader.ReadString();
                    Console.WriteLine(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
