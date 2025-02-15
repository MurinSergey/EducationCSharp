## Задание 7.5.5
Измените класс Obj так, чтобы статические поля инициализировались в статическом конструкторе:

class Obj 
{
  public string Name;
  public string Description;

  public static string Parent = "System.Object";
  public static int DaysInWeek = 7;
  public static int MaxValue = 2000;
}