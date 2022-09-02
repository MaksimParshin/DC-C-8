// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumber(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write($"{start}, ");
    PrintNumber(start + 1, end);
}

int m = 1;
int n = 15;
PrintNumber(m, n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumber(int a, int b)
{
    if (a > b)
    {
        return 0;
    }
    return (a + SumNumber(a + 1, b));
}

Console.WriteLine(SumNumber(4, 8));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
    return AckermannFunction(M, N);
}

Console.WriteLine(AckermannFunction(2, 3));