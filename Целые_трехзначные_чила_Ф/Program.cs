/* Программа должна иметь метод CountEvenElements, 
который принимает массив целых положительных трехзначных чисел и 
возвращает количество четных элементов в массиве. */
/* Программа должна иметь метод PrintArray, 
который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t". */

using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
        int result = 0;
    
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result =+ i;
            }
        }
        return result;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write($"{number}\t");
        }
        Console.WriteLine();

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}