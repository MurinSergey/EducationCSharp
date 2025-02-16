namespace Module_09.Quest_914
{
    internal class Quest_914
    {
        internal static void Run()
        {
			try
			{
				var exception = new Exception("Тестовое исключение");
				exception.HelpLink = "https://ya.ru/";
				throw exception;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.HelpLink);
			}
        }
    }
}
