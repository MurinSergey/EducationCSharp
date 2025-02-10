using Module_07.Quest_Final.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07.Quest_Final.Store
{
    public class Menu()
    {
        /// <summary>
        /// Список всех продуктов в текущем меню
        /// </summary>
        private List<Product.Product> _products = [];

        /// <summary>
        /// Индексатор, который позволяет брать продукты из меню
        /// </summary>
        /// <param name="index"></param>
        /// <returns>
        /// Возвращает продукт из меню
        /// </returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public Product.Product this[Index index]
        {
            get
            {
                int intIndex = index.GetOffset(_products.Count);
                if (intIndex < 0 || intIndex > _products.Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return _products[index].Clone();
            }
        }
        /// <summary>
        /// Метод возвращает количество продуктов в меню
        /// </summary>
        /// <returns>
        /// Количество продуктов в меню
        /// </returns>
        public int Count
        {
            get
            {
                return _products.Count;
            }
        }

        public void AddToMenu(Product.Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException("Переданный продукт не задан");
            }
            _products.Add(product);
        }

        public void AddToMenu(List<Product.Product> products)
        {
            if (products is null)
            {
                throw new ArgumentNullException("Переданный продукт не задан");
            }
            _products.AddRange(products);
        }

        /// <summary>
        /// Предоставляем информацию о всех продуктах в меню
        /// </summary>
        /// <returns>
        /// Если в меню нет продуктов, то возвращает false
        /// </returns>
        public bool PrintMenu()
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("К вашему вниманию меню нашего ресторана: ");
            if (_products.Count < 1)
            {
                ConsoleUtils.WriteLine("К сожалению у нас ничего нет");
                return false;
            }
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_products[i].GetInfo()}");
            }
            return true;
        }
    }
}
