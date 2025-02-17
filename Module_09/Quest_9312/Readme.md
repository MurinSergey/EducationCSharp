## ������� 9.3.12
���������� ��������� ���������� �������, ������� ���������� ��������� Hello World � ���������� ���������:

    namespace DelegatePractices
    {
        class Program
        {
            delegate void ShowMessageDelegate(string _message);
            static void Main(string[] args)
            {
                ShowMessageDelegate showMessageDelegate = ShowMessage;
                showMessageDelegate.Invoke("Hello World!");
                Console.Read();
            }

            static void ShowMessage(string _message)
            {
                Console.WriteLine(_message);
            }
        }
    }

���������� � ������ ������� ��������� �����, �� ������ ������ ����������.