// Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

string[] days = new String[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите номер дня недели:");
int day = int.Parse(Console.ReadLine());

  if (day < 1 || day > 7)
  {
    Console.WriteLine("Неверный ввод числа!");
  }
  else
  {
    if (day == 6 || day == 7)
    {
      Console.WriteLine($"{(days[day - 1])} - выходной день!");
    }
    else
    {
      Console.WriteLine($"{(days[day - 1])} - будний (рабочий) день!");
    }
  }
