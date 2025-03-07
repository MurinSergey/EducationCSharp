using Module_09.Quest_Final.Exceptions;

namespace Module_09.Quest_Final.First_Quest;

public class Main
{
    internal static void Run()
    {
        Console.WriteLine("====Выполняем программу первого задания====");

        //Массив из пяти исключений
        Exception[] exceptions = [
            new NotImplementedException(),
            new FormatException(),
            new MyFirstException(),
            new ArgumentNullException(),
            new ArgumentOutOfRangeException()
        ];

        foreach (Exception ex in exceptions)
        {
            try
            {
                throw ex;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Сработало исключение {exception.GetType().Name}: {exception.Message}");
            }
            finally
            {
                Console.WriteLine();
            }
        }

    }
}
