using System;

//task02
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 1;
int b = 0;
int c = -50;
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное число {max}");