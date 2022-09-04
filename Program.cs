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

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int A(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return A(m-1, 1);
//     if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
//     return A(m, n);
// }

// Console.WriteLine($"Функция Аккермана при {m} и {n} равна: {A(m, n)}");


