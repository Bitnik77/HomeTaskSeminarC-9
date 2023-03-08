// Задача №66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

string PrintNumbers(int m, int n)
{
    if (n == m) return n.ToString();
    else
    {
        return PrintNumbers(m, n - 1) + $" {n}";
    }
}

int SumNumbers(int m, int n)
{
    if (m == n) return n;
    else
    {
        return SumNumbers(m, n - 1) + n;
    }
}

void Main()
{
    Console.Clear();
    Console.Write("Введите число М: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);
    if (n == m)
    {
        Console.WriteLine($"Числа введенного диапазона: {n}");
        Console.WriteLine($"Сумма чисел введенного диапазона = {n}");
    }
    else
    {
        Console.WriteLine("Все числа введенного дипазона: " + PrintNumbers(m, n));
        Console.Write("Сумма чисел введенного дипазона = " + SumNumbers(m, n));
    }
}

Main();