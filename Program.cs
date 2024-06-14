// Решение задачи № 1
// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    Console.Write("Введите значение M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Натуральные числа от {M} до {N}:");
    PrintNumbers(M, N);
}

void PrintNumbers(int current, int limit)
{
    if (current > limit)
        return;

    Console.Write($"{current} ");
    PrintNumbers(current + 1, limit);
}

Main();


// Решение задачи № 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void MainSecond()
{
    Console.Write("Введите неотрицательное число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите неотрицательное число n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int result = Ackermann(m, n);
    Console.WriteLine($"Результат функции Аккермана для чисел ({m}, {n}): {result}");
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

MainSecond();
