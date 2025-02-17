namespace Module_09.Quest_923;

internal class Quest_923
{
    internal static void Run()
    {
		try
		{
			throw new RankException();
		}
		catch (RankException ex)
		{
			Console.WriteLine(ex.GetType());
		}
		finally
		{
			Console.WriteLine("Выполнение блока finally");
		}
    }
}
