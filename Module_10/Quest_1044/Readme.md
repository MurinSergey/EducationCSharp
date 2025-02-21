## Задание 10.4.4

Определены два класса:

	public class User 
	{

	}

	public class Account: User 
	{

	}

Определён обобщённый интерфейс:

	public interface IUpdater <in T> 
	{
	  void Update(T entity);
	}

Реализуйте данный интерфейс в классе UserService, и продемонстрируйте контравариацию интерфейса в базовом классе Program.