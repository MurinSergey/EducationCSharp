using System.Collections;

namespace Module_09.Quest_913;

internal class Quest_913
{
    internal static void Run()
    {

		try
		{
			var exception = new Exception();
			exception.Data.Add("Дата формирования исключения", DateTime.Now);
			throw exception;
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			foreach (DictionaryEntry entry in e.Data)
			{
				Console.WriteLine($"{entry.Key}: {entry.Value}");
			}
		}
    }
}

