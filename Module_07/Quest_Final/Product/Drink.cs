using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07.Quest_Final.Product
{
    public class Drink(string name, string description, decimal price, double volume, DrinkType drinkType) : Product(name, description, price)
    {
        /// <summary>
        /// Тип напитка
        /// </summary>
        private DrinkType _drinkType = drinkType;
        /// <summary>
        /// Объем напитка
        /// </summary>
        private double _volume = volume;

        public DrinkType DrinkType
        {
            get { return _drinkType; }
            set { _drinkType = value; }
        }

        public double Volume
        {
            get { return _volume; }
            set { 
                if (value <= 0)
                {
                    throw new ArgumentException("Объем напитка не может быть отрицательным или равным нулю.");
                }
                _volume = value;
            }
        }

        public Drink(Drink drink) : this(drink.Name, drink.Description, drink.Price, drink.Volume, drink.DrinkType)
        {
        }

        public override string GetInfo()
        {
            return $"Название: {Name}, Тип напитка: {DrinkType.ToRussianString()}, Описание: {Description}, Объем: {Volume} мл., Цена: {Price} руб.";
        }

        public override Drink Clone()
        {
            return new Drink(this);
        }
    }
}
