using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07.Quest_Final.Product
{
    /// <summary>
    /// Доступные типы блюд
    /// </summary>
    public enum DishType
    {
        MainCourse, // Основное блюдо
        Dessert,    // Десерт
        Appetizer,  // Закуска
        Salad,      // Салат
        Soup        // Суп
    }

    public static class DishTypeMethod
    {
        /// <summary>
        /// Метод расширения для перечисления типа блюд 
        /// </summary>
        /// <param name="type"></param>
        /// <returns>
        /// Возвращает значение на русском языке
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToRussianString(this DishType type)
        {
            return type switch
            {
                DishType.MainCourse => "Главное блюдо",
                DishType.Dessert => "Десерт",
                DishType.Appetizer => "Закуска",
                DishType.Salad => "Салат",
                DishType.Soup => "Суп",
                _ => throw new NotImplementedException() //Выбрасывем исключение, если тип не задан
            };
        }
    }
}
