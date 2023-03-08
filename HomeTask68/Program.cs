// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if (n != 0 && m == 0)
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}

void Main()
{
    Console.Clear();
    Console.Write("Введите положительное число М: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите положительное число N: ");
    int n = int.Parse(Console.ReadLine()!);
    if (m >= 4 && n >= 1 || m >= 3 && n >= 12)
    {
        Console.WriteLine("Для заданных чисел значение функции Аккермана настолько велико, " +
        "что компьютер не сможет его обработать. Задайте числа меньше.");
    }
    else Console.Write($"Значение функции Аккермана для чисел {m} и {n} равно {Akkerman(m, n)}");
}

Main();