/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2 */

/* void ArraySwapRows(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];

    for(int i = 0; i < temp.Length; i++)
    {
        temp[i] = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
    }

    for(int i = 0; i < temp.Length; i++)
    {
        arr[arr.GetLength(0) - 1, i] = temp[i];
    }
}


int[,] array = {{1,2,3,4}, {5,6,7,8}, {9,10,11,12}};

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

ArraySwapRows(array);


for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
} */

