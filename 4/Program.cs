// Напишите программу, которая на вход принимает чмсло(N), а на выходе показывает все четные числа от 1 до N.


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()); 
int start = 1;
int count = 0;

while(start <= number)
     {
        if(start % 2 == 0)
       Console.WriteLine(start + ", ");
       start++;
     } 
       Console.WriteLine(number);

       //готово
     