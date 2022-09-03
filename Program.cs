// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// int M = Convert.ToInt32(Console.ReadLine());
// int N = int.Parse(Console.ReadLine());

// if (M > N) return;
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// Console.WriteLine(PrintNumbers(M, N));

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M = Convert.ToInt32(Console.ReadLine());
// //int N = int.Parse(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());
// int Sum(int M, int N)
// {
//     if (M == N) return M;
//     return (M + Sum(M + 1, N));
// }

// Console.WriteLine($"Сумма чисел от {M} до {N} равна: {Sum(M, N)}");

// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int m = Convert.ToInt32(Console.ReadLine());
//int N = int.Parse(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int Sum(int m, int n)
{
    if (m == n) return m;
    return (m + Sum(m + 1, n));
}

Console.WriteLine($"Сумма чисел от {m} до {n} равна: {Sum(M, N)}");


