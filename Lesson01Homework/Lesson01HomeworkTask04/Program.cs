﻿using System;

//task04
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Write number N: ");
int n = int.Parse(Console.ReadLine());
if (n >= 0)
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
