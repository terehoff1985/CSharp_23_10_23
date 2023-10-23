/* Напишите программу, которая находит сумму элементов с нечетными индексами
 в одномерном массиве целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, 
который принимает массив целых чисел и 
возвращает сумму элементов с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, 
который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t". */

using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
      int result = 0;
    
        for (int i = 1; i < array.Length; i+=2)
        {
        
            result += array[i];
            
        }
        return result;


    }

    public static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write($"{i}\t");
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
            array = new int[] { 1, 3, 5, 8};
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
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}