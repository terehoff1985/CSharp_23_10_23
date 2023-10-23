/* 31. Задайте массив c клавиатуры из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
 */

    


int[] MyNumberElements(int len, int min, int max)
{
    
    int[] array = new int[len];
    var random = new Random();
    for (int i = 0; i < len; i++)
    { 
        array[i] = random.Next(min,max);  
    }
    return array;
}
void Output(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    
    
    }
}
    int min,max,len;
    System.Console.WriteLine("Введите количество элементов в массиве:");
    len = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите минимальное значение элемента:");
    min = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите максимальное значение элемента:");
    max = int.Parse(Console.ReadLine());
    System.Console.WriteLine("В Массиве:");
    int[] result = MyNumberElements(len, min, max);
    Output(result);
   
    

int MinusElements(int[] array)
{
int negativeSum = 0;
    foreach (int num in array)
    {
        if (num < 0)
        {
            negativeSum += num;
        }
    }
     

    return negativeSum;
}
int[] PlusElements(int[] array)
{
    int positiveSum = 0;
    foreach (int num in array)
    {
        if (num > 0)
        {
            positiveSum += num;
        }
    }
    return array; 
}

 
