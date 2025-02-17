## Задание 9.3.13
Существует консольное решение, которое выводит случайное целое число в диапазоне от 0 до 100 и отображает результат в консольное сообщение:

    namespace DelegatePractices
    {
        class Program
        {
            delegate int RandomNumberDelegate();
            static void Main(string[] args)
            {
                RandomNumberDelegate randomNumberDelegate = RandomNumber;
                int result = randomNumberDelegate.Invoke();
                Console.WriteLine(result);
                Console.Read();
            }

            static int RandomNumber()
            {
                return new Random().Next(0, 100);
            }
        }
    }

Реализуйте в данном решении анонимный метод, не сломав логику приложения.