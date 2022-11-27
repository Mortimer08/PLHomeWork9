// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintSequence(int number)
{
    string devider = number > 1 ? ", " : "";
    Console.Write($"{number}{devider}");
    if (number > 1) PrintSequence(number - 1);
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.Write($"N = {number} -> \"");
    PrintSequence(number);
    Console.WriteLine("\"");
}
else System.Console.WriteLine("Введено число менее единицы");