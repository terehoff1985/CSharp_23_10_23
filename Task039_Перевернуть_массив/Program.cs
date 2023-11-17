/* Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.) */

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length -1) // [5, 7, 1, 4]
        System.Console.Write(", ");
    }
    System.Console.Write("]");
    Console.ResetColor();
}



int[] FlipArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        // [4, 9, 2, 8]
        temp = arr[i]; // [4], [9]
        arr[i] = arr[arr.Length -1 -i]; // [8, 9, 2, 8], [8, 2, 2, 4]
        arr[arr.Length -1 -i] = temp; // [8, 9, 2, 4], [8, 2, 9, 4]
    }
    return arr;
}

int[] userArray = GetArray(5);
PrintArray(userArray);
System.Console.WriteLine();
PrintArray(FlipArray(userArray));