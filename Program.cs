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

    Console.WriteLine($"Натуральные числа от {M} до {N}: ");
    PrintNumbers(M, N);
}

void PrintNumbers(int current, int limit)
{
    if (current > limit)
        return;

    Console.Write($"{current} ");
    PrintNumbers(current + 1, limit);
}


Console.WriteLine("------------- Задача № 1 -------------\n");

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
    Console.WriteLine($"Результат функции Аккермана для чисел ({m}, {n}): {result} ");
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

Console.WriteLine("\n\n------------- Задача № 2 -------------\n");

MainSecond();


// Задача № 3 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


void MainThird()
{
    int[] array = new int[5];
    FillArrayWithRandomNumbers(array);
    PrintArrayReverse(array, array.Length - 1);
}

void FillArrayWithRandomNumbers(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    PrintArrayReverse(array, index - 1);
}

Console.WriteLine("\n------------- Задача № 3 -------------\n");

MainThird();