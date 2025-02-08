using System;

namespace Module_07.Quest_Final.Store;

public static class Store
{
    /// <summary>
    /// Меню нашего ресторана
    /// </summary>
    private static Menu _storeMenu;

    public static Menu StoreMenu
    {
        get { return _storeMenu; }
    }

    static Store()
    {
        _storeMenu = CreateMenu();
    }
    private static Menu CreateMenu()
    {
        Menu menu = new();
        menu.AddToMenu([
            new Product.Dish("Котлета с пюрешкой", "Самая вкусная мясная котлета в сочетании с бесподобным пюре из отборного картофана", 30, 500, Product.DishType.MainCourse),
            new Product.Dish("Салат из какой-то зелени", "Мама всегда говорила: \"Ешь салат!!!\"", 90, 450, Product.DishType.Salad),
            new Product.Dish("Блин с икрой", "Большой и вкусный блин с красной икрой", 100, 300, Product.DishType.Appetizer),
            new Product.Dish("Борщ", "Это самый настояший борщ! И он бесценен", 500, 200, Product.DishType.Soup),
            new Product.Dish("Киндер сюрприз", "Отличный десерт! И чай попить, и поиграть, и яйцами померяться :)", 200, 100, Product.DishType.Dessert),
            new Product.Drink("Черный чай", "Самый обычный черный чай", 10, 300, Product.DrinkType.NonAlcoholic),
            new Product.Drink("Пыво", "Именно, что не пиво, а пЫво!", 50, 500, Product.DrinkType.Alcoholic)
            ]);
        return menu;
    }
}
