using System;


// Задача 1
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//   int cuter(int a)
//    {
//            return ((a / 100) * 10 + a % 10);
//    }
//Random randomeizer = new Random();
//    int value = randomeizer.Next(100, 999);
//    Console.WriteLine($"Сгенерированное число {value}");
//    int temp = cuter(value);
//    Console.WriteLine($"Ответ {cuter(value)}"); 





// Задача 2
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число  
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine() );
int remainder = (value1 % value2);
if (remainder == 0)
{
    Console.WriteLine($"Число {value1} является кратным числу {value2}");
}
else
{
    Console.WriteLine($"Число {value1} не является кратным числу {value2}, остаток ({remainder})");
}




