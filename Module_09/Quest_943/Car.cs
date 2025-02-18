using System;

namespace Module_09.Quest_943;

/// <summary>
/// Базовый класс машины
/// </summary>
/// <param name="model">Название модели</param>
internal class Car(string model)
{

    /// <summary>
    /// Модель машины
    /// </summary>
    internal string Model { get;  private set; } = model;
}
