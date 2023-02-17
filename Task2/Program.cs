// Программа, которая выводит третью цифру заданного числа, или
// сообщает, что третьей цифры нет!

Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine(), out int first);
int length = first.ToString().Length;
int a;

if (length == 3)
{
  a = first % 10;
    Console.WriteLine($"Третья цифра числа: {first} равна {a}");
}
if (length < 3)
{
  Console.WriteLine($"Третьей цифры числа {first} НЕТ!");
}
if (length > 3)
{
    Console.WriteLine($"Третьей цифрой числа {first} является {first.ToString()[2]}");
}
