using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07.Quest_Final.Product
{
    public enum DrinkType
    {
        NonAlcoholic, //Не алкогольный
        Alcoholic   //Алкогольный
    }


    public static class DrinkTypeMethod
    {
        /// <summary>
        /// Метод расширения для перечисления типов напитков 
        /// </summary>
        /// <param name="type"></param>
        /// <returns>
        /// Возвращает значение на русском языке
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToRussianString(this DrinkType type)
        {
            return type switch
            {
                DrinkType.NonAlcoholic => "Не алкогольный",
                DrinkType.Alcoholic => "Алкогольный",
                _ => throw new NotImplementedException()
            };
        }
    }
}
