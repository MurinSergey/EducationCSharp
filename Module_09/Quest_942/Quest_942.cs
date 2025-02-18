using System;

namespace Module_09.Quest_942;

internal class Quest_942
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
            Описываем Ковариативность
            Таким образом любой возращаемый методом или делегатом объект производного (дочернего) класса можно привести к базовому (родительскому)
        */
        Func<string, Lexus> buildLexus = GetLexus;
        Func<string, Toyota> buildToyota = GetToyota;

        Func<string, Car> buildCar1 = buildLexus;
        Func<string, Car> buildCar2 = buildToyota;

        Car lexus = buildCar1("LX30");
        Car lexus1 = buildLexus("LX300");

        Car toyota = buildCar2("Camry");
        Car toyota1 = buildToyota("Corolla");

        PrintInfo(lexus);
        PrintInfo(lexus1);

        PrintInfo(toyota);
        PrintInfo(toyota1);
    }
}
