namespace Module_09.Quest_922;
internal class Quest_922
{
    internal static void Run()
    {
        try
        {
            throw new ArgumentOutOfRangeException();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Вполнение блока finally");
        }
    }
}