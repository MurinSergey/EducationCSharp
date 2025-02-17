## «адание 9.3.12
—уществует следующее консольное решение, которое отображает сообщение Hello World в консольном сообщении:

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

–еализуйте в данном решении анонимный метод, не сломав логику приложени€.