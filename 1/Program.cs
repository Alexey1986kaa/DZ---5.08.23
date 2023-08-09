// напишите программу , которая на вход принимает два числа и выдает какое из
// них большее, а какое меньшее.
// a = 5; b = 7 -> max = 7


Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше,чем {number2}");
}
else
{
     Console.WriteLine($"Число {number2} больше, чем {number1}");
}
// готово
