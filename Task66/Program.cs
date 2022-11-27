// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumders(int numM, int numN)
{
    if (numM == numN) return numN;
    return numN + SumNaturalNumders(numM, numN - 1);
}

Console.WriteLine("Введите два натуральных числа: ");
Console.Write("Число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    if (numberM > numberN)
    {
        int temporary = numberM;
        numberM = numberN;
        numberN = temporary;
    }
    int sumNaturalNumbers = SumNaturalNumders(numberM, numberN);
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {sumNaturalNumbers}");
}
else System.Console.WriteLine("Введено некорректное значение");