// Напишите программу , которая на вход принимает число и выдает, является ли
// число четным (делится ли оно на 2 без остатка).

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()); 

if(number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else
{
    Console.WriteLine($"Число {number} не является четным");
}