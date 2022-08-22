
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int value = int.Parse(Console.ReadLine());
value = Math.Abs(value);

int size = value.ToString().Length;
if (size > 2)
{

    int[] Array = new int[size];

    while (value != 0)
    {
        Array[size - 1] = value % 10;
        value = value / 10;
        size--;
    }
    Console.WriteLine($"Третья цифра числа: {Array[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
