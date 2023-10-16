/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using System;

class Program
{
    int  MyResult1 (int)
    {
        System.Console.Write("Введите число 1: ");

        int Number1 = int.Parse(Console.ReadLine());

        System.Console.Write("Введите число 2: ");

        int Number2 = int.Parse(Console.ReadLine());

        int result = 1;

        if (Number2< 1) 
        {
            System.Console.WriteLine("Число 2 не натуральное!!!");
        }
        else
        {
            while (Number2 != 0)
            {
            result = result * Number1;
            Number2 = Number2 - 1;
            }
            return(result);
        }



 
        System.Console.WriteLine($"Число {Number1} в нвтуральной степени {Number2} равно {result} "); 
    }

}
