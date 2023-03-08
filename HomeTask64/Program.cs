// Задача №64. Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string PrintNumbers(int n)
{
    if (n == 1) return "1";
    else
    {
        return $"{n} " + PrintNumbers(n - 1);  //или так return n.ToString() + " " + PrintNumbers(n - 1);

    }
}

void Main()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(PrintNumbers(n));
}

Main();