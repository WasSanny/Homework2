// Программа, которая на вход принимает трехзначное число, и
// на выходе показывает вторую цифру!

Console.WriteLine("Введите трехзначное число: ");
int.TryParse(Console.ReadLine(), out int first);
int length = first.ToString().Length;
int a;
int b;

if (length == 3)
{
  a = first / 10;
  b = a % 10;
  Console.WriteLine($"Вы ввели трёхзначное число: {first}, вторая цифра которого = {b}.");
}
else
{
  Console.WriteLine("Вы ввели не трёхзначное число!");
}