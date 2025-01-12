namespace Module_08;

class Program
{
    static void Main(string[] args)
    {
        DriveInfo[] drivers = DriveInfo.GetDrives();

        foreach (DriveInfo driver in drivers)
        {
            Console.WriteLine("===================================================");
            Console.WriteLine($"Название: {driver.Name}");
            Console.WriteLine($"Тип: {driver.DriveType}");
            if (driver.IsReady)
            {
                Console.WriteLine($"Объем: {driver.TotalSize}");
                Console.WriteLine($"Свободно: {driver.TotalFreeSpace}");
                Console.WriteLine($"Метка: {driver.VolumeLabel}");
            }
            Console.WriteLine("===================================================");
        }
        
    }
}
