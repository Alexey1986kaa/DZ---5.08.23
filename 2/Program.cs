//напишите программу, котрая принимает на вход 3 числа и выдает максимальное из этих чисел.

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;

if(number2 > max) max = number2;

if(number3 > max) max = number3;
{
    Console.WriteLine(max);
}