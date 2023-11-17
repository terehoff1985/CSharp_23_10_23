 /* Напишите программу, которая будет создавать копию заданного 
 одномерного массива 
 с помощью поэлементного копирования. */


 int[] CreateArray(int size, int min, int max)
{
    var random = new Random();
    
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) 
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
}

int[] MyNewArray(int[] arr)
{
    int size = arr.Length; 
    int[] copyarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        copyarray[i] = arr[i];
    }
    return copyarray;
}
int[] originalArray = CreateArray(10, 1, 100); // Создаем и заполняем исходный массив
Console.WriteLine("Original Array:");
Output(originalArray); // Выводим исходный массив
int[] copiedArray = MyNewArray(originalArray); // Создаем копию массива
Console.WriteLine("\nCopied Array:");
Output(copiedArray); // Выводим копированный массив

