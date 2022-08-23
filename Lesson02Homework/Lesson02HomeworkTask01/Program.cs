
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine($"Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (number > 99 && number < 1000)
{
    number = (number / 10) % 10;
    Console.WriteLine($"вторая цифра заданного числа: {number}");
}
else
{
    Console.WriteLine("Вы ввели некорректное число, попробуйте снова");
}
