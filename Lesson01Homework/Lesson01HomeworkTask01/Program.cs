﻿using System;

//task01
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 10;
int b = 5;
if (a > b)
{
    Console.WriteLine($"Максимальное число {a}, наименьшее число {b}");
}
else
{
    Console.WriteLine($"Максимальное число {b}, наименьшее число {a}");
}