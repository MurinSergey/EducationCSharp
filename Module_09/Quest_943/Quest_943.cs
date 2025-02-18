using System;

namespace Module_09.Quest_943;

internal class Quest_943
{
    /// <summary>
    /// Метод изготавливает новую машину марки Lexus
    /// </summary>
    /// <param name="model">Название модели</param>
    /// <returns>
    /// Возвращает машину Lexus
    /// </returns>
    private static Lexus GetLexus(string model)
    {
        return new Lexus(model);
    }

    /// <summary>
    /// Метод изготавливает новую машину марки Toyota
    /// </summary>
    /// <param name="model">Название модели</param>
    /// <returns>
    /// Возвращает машину Toyota
    /// </returns>
    private static Toyota GetToyota(string model)
    {
        return new Toyota(model);
    }

    /// <summary>
    /// Метод выводит информацию о машине
    /// </summary>
    /// <param name="car">Экземпляр машины</param>
    private static void PrintInfo(Car car)
    {
        Console.WriteLine($"Машина марки: {car.GetType().Name} Модель: {car.Model}");
    }

    internal static void Run()
    {
        /*
            Описываем Контрвариативность
            Таким образом любой метод ожидающий на вход объект базового (родительского) класса может принять объект производного (дечернего) класса
        */
        Func<string, Lexus> buildLexus = GetLexus;
        Func<string, Toyota> buildToyota = GetToyota;

        Action<Car> printInfo = PrintInfo;

        printInfo(buildLexus("LX100"));
        printInfo(buildToyota("Camry"));
    }
}
