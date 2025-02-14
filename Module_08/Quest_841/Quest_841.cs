using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08.Quest_841
{
    public class Quest_841
    {
        public static void Run()
        {
            byte[] binaryFile = Resources.BinaryFile;
            
            try
            {
                using MemoryStream memoryStream = new(binaryFile);
                using BinaryReader reader = new(memoryStream);
                string str = "";
                while ((str = reader.ReadString()) != null)
                {
                    Console.Write(str);
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
