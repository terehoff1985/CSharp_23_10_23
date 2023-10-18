/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using System;


class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите степень B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        int result = Power(A, B);

        Console.WriteLine($"{A} в степени {B} равно {result}");
    }

    static int Power(int A, int B)
    {
        int result = 1;

        for (int i = 0; i < B; i++)
        {
            result *= A;
        }

        return result;
    }
}

