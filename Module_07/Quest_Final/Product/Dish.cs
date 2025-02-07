using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07.Quest_Final.Product
{
    public class Dish(string name, string description, decimal price, double weight, DishType dishType) : Product(name, description, price)
    {

        /// <summary>
        /// Вес блюда
        /// </summary>
        private double _weight = weight;
        /// <summary>
        /// Тип блюда
        /// </summary>
        private DishType _dishType = dishType;

        public double Weight
        {
            get { return _weight; }
            set { 
                if (value <= 0)
                {
                    throw new ArgumentException("Вес блюда не может быть отрицательным или равным нулю.");
                }
                _weight = value;
            }
        }

        public DishType DishType
        {
            get { return _dishType; }
            set { _dishType = value; }
        }

        public override string GetInfo()
        {
            return $"Название: {Name}, Тип блюда: {DishType.ToRussianString()}, Описание: {Description}, Вес: {Weight}, Цена: {Price}";
        }
    }
}
