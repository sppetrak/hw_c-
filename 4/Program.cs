﻿Console.WriteLine("Введите число N: ");
int N =int.Parse(Console.ReadLine()!);

int i = 1;
while(i <= N)
{
    if(i%2==0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
