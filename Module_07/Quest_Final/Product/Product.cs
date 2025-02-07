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
}

