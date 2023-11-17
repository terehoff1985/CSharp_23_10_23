/* Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел (M): ");
        int M = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[M];

        for (int i = 0; i < M; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int count = PlusNumberCount(numbers);
        Console.WriteLine($"Количество чисел больше 0: {count}");
    }

    static int PlusNumberCount(int[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                count++;
        }

        return count;
    }
}
   