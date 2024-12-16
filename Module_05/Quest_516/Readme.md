## Задание 5.1.6
### после ввода массива с клавиатуры необходимо отсортировать массив и вывести его на экран. 
Модифицировать код из видео:
static int[] GetArrayFromConsole() {
  var result = new int[5];

  for (int i = 0; i < result.Length; i++) {
    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    result[i] = int.Parse(Console.ReadLine());
  }

  return result;
}