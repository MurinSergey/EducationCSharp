namespace Module_05
{
    internal class Program
    {
        static (string Name, string LastName, byte Age, string[] PetsName, string[] FavColors) EnterUserInfo()
        {
            (string Name, string LastName, byte Age, string[] PetsName, string[] FavColors) user;
            user.PetsName = [];
            user.FavColors = [];

            bool repeat = false;
            do
            {
                Console.Write("<<<Ваше имя: ");
                user.Name = Console.ReadLine();
                repeat = !IsAlpha(user.Name);
                if (repeat)
                    Console.WriteLine(">>>Некорректное имя - используйте только буквы");
            }while(repeat);

            do
            {
                Console.Write("<<<Ваша фамилия: ");
                user.LastName = Console.ReadLine();
                repeat = !IsAlpha(user.LastName);
                if (repeat)
                    Console.WriteLine(">>>Некорректная фамилия - используйте только буквы");
            } while (repeat);

            do
            {
                Console.Write("<<<Ваш возраст: ");
                repeat = !CheckNum(Console.ReadLine(), out user.Age);
                if (repeat)
                    Console.WriteLine(">>>Некорректный возраст - диапазон от 1 до 255");
            } while (repeat);

            do
            {
                repeat = false;
                Console.Write("<<<Наличие питомцев(Да/Нет): ");
                switch (Console.ReadLine())
                {
                    case "Да":
                        byte num = 0;
                        do
                        {
                            Console.Write("<<<Укажите количество питомцев: ");
                            repeat = !CheckNum(Console.ReadLine(), out num);
                            if (repeat)
                                Console.WriteLine(">>>Некорректный возраст - диапазон от 1 до 255");
                        } while (repeat);
                        user.PetsName = GetArraySringFromConsole("питомец", num);
                        break;
                    case "Нет":
                        break;
                    default:
                        repeat = true;
                        break;
                        
                }
                if (repeat)
                    Console.WriteLine(">>>Некорректный ответ - используйте Да или Нет");
            } while (repeat);

            do
            {
                repeat = false;
                Console.Write("<<<Любимый цвет(Да/Нет): ");
                switch (Console.ReadLine())
                {
                    case "Да":
                        byte num = 0;
                        do
                        {
                            Console.Write("<<<Укажите количество любимый цветов: ");
                            repeat = !CheckNum(Console.ReadLine(), out num);
                            if (repeat)
                                Console.WriteLine(">>>Некорректный возраст - диапазон от 1 до 255");
                        } while (repeat);
                        user.FavColors = GetArraySringFromConsole("любимый цвет", num);
                        break;
                    case "Нет":
                        break;
                    default:
                        repeat = true;
                        break;

                }
                if (repeat)
                    Console.WriteLine(">>>Некорректный ответ - используйте Да или Нет");
            } while (repeat);

            return user;
        }

        static void PrintUserInfo((string Name, string LastName, byte Age, string[] PetsName, string[] FavColors) user)
        {
            Console.WriteLine($">>>Вас зовут: {user.LastName} {user.Name}");
            Console.WriteLine($">>>Ваш возраст: {user.Age} лет");
            if (user.PetsName.Length > 0)
            {
                Console.WriteLine($">>>У вас {user.PetsName.Length} питомцев по имени:");
                PrintArrayItems(user.PetsName);
            }
            else
            {
                Console.WriteLine($">>>У вас нет питомцев");
            }
            if (user.FavColors.Length > 0)
            {
                Console.WriteLine($">>>У вас {user.FavColors.Length} любимых цветов:");
                PrintArrayItems(user.FavColors);
            }
            else
            {
                Console.WriteLine($">>>У вас нет любимых цветов");
            }
        }

        //Проверяем, что это буквы и не NULL
        private static bool IsAlpha(string? str) {
            return str != null && str.All(Char.IsLetter);
        }

        //Проверяем, что ввели корректное число
        private static bool CheckNum(string? str, out byte num)
        {
            num = 0;
            bool result = false;
            if (int.TryParse(str, out int rsl))
            {
                if (rsl > 0 && rsl <= Byte.MaxValue)
                {
                    num = (byte)rsl;
                    result = true;
                }
            }
            return result;
        }

        private static string[] GetArraySringFromConsole(string type, int num)
        {
            var arr = new string[num];
            bool repeat = false;
            int i = 0;
            do
            {
                Console.Write($"<<<Введите \"{type}\" номер {i + 1}: ");
                string? str = Console.ReadLine();
                repeat = !IsAlpha(str);
                if (repeat)
                {
                    Console.WriteLine(">>>Некорректная строка - используйте только буквы");
                }
                else
                {
                    arr[i] = str;
                    i++;
                }
            } while (repeat || i < num);
            return arr;
        }

        private static void PrintArrayItems(string[] arr)
        {
            foreach (string item in arr)
            {
                Console.WriteLine($">>>{item};");
            }
        }

        static void Main(string[] args)
        {
            PrintUserInfo(EnterUserInfo());
        }
    }
}
