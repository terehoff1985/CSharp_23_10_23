/* Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран. */

class Program
{
    static void Main(string[] args)
    {
        int length = PrintMyMassive("Количество элементов массива: ");
        int[] array = MyArrayElements(length);
        PrintMyMassive(array);
    }

    static int PrintMyMassive(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        int result = int.Parse(Console.ReadLine());
        return result;
    }

    static int[] MyArrayElements(int length)
    {
        Console.WriteLine("Введите {0} элементов массива:", length);
        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        return arr;
    }

    static void PrintMyMassive(int[] arr)
    {
        Console.WriteLine("Массив:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            Console.Write(", ");
        }
    }
}
