/* Реализуйте класс ArrayOperations, который содержит следующие статические методы:
Fin max(double[] array): Метод принимает на вход массив вещественных чисел array
 и возвращает максимальное число из массива.
Fin max(double[] array): Метод принимает на вход массив вещественных чисел array 
и возвращает минимальное число из массива.
CalcDifferenceBetwee max(double[] array): Метод принимает на вход массив 
вещественных чисел array и возвращает разницу между максимальным и 
минимальным числами в массиве.
PrintArray(double[] array): Метод для вывода массива на экран. 
Он принимает на вход массив array и выводит его элементы 
с двумя знаками после запятой через табуляцию. */

using System;

public class Answer
{
    public static double FindMax(double[] array)
    {    
        double max = array[0];
        
        for (int i = 0; i < array.Length; i++)
        {
    
            if (max < array[i]) 
            {
                max = array[i];
            }
        
        }
        return max;

       
    }

    public static double FindMin(double[] array)
    {     
         double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
          
            if (min > array[i]) 
            {
                min = array[i];
            }
        
        }
        return min;

    }

    public static double CalcDifferenceBetween(double[] array)
    {
        return FindMax(array) - FindMin(array);    
    }


    public static void PrintArray(double[] array)
    {
        foreach (double number in array)
        {
            Console.Write($"{number:f2}\t");
        }
        Console.WriteLine();

    }



    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
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

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetween(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}
