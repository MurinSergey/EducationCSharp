## ������� 10.4.4

���������� ��� ������:

	public class User 
	{

	}

	public class Account: User 
	{

	}

�������� ���������� ���������:

	public interface IUpdater <in T> 
	{
	  void Update(T entity);
	}

���������� ������ ��������� � ������ UserService, � ����������������� �������������� ���������� � ������� ������ Program.