// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void GetNext(int m, int n)
// {
//     if (m < n)
//     {
//         GetNext(m+1, n);
//         Console.Write(m + " ");
//     }
//     else if (n < m)
//     {
//         GetNext(m, n+1);
//         Console.Write(n + " ");
//     }
//     else Console.Write(m);
// }

// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());

// GetNext(1, n);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumNat(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumNat(m, n);
//         return res;
//     }
// }

// Console.Write(SumNat(m-1, n));

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// Console.Write(Akkerman(m,n));














































