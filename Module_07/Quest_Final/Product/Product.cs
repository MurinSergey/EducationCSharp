using System;

namespace Module_07.Quest_Final.Product;

public abstract class Product(string name, string description, decimal price)
{
    /// <summary>
    /// Наименование продукта
    /// </summary>
    private string _name = name;

    /// <summary>
    /// Описание товара
    /// </summary>
    private string _description = description;

    /// <summary>
    /// Стоимость продукта
    /// </summary>
    private decimal _price = price;

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Имя продукта не может быть пустым.");
            }
            _name = value;
        }
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Цена продукта не может быть отрицательной.");
            }
            _price = value;
        }
    }

    public string Description
    {
        get { return _description; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Описание продукта не может быть пустым.");
            }
            _description = value;
        }
    }

    /// <summary>
    /// Метод должен возвращать описание продукта
    /// </summary>
    /// <returns>
    /// Описание продукта
    /// </returns>
    public abstract string GetInfo();

    /// <summary>
    /// Метод для реализации копирования продукта
    /// </summary>
    /// <returns>
    /// Копия текущего продукта
    /// </returns>
    public abstract Product Clone();

    /// <summary>
    /// Перегрузка оператора сложения +
    /// </summary>
    /// <param name="left_product"></param>
    /// <param name="right_product"></param>
    /// <returns>
    /// Возвращает сумму для двух переданных продукта
    /// </returns>
    public static decimal operator + (Product left_product, Product right_product)
    {
        return left_product.Price + right_product.Price;
    }
}

