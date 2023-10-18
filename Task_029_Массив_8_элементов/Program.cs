/* Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран. */





    Console.Clear();   
    int[] result = new int[8];
    MyArrayElements(result);
    Console.WriteLine("Введенные элементы массива: ");
    Array.ForEach(result, item => Console.WriteLine(item)); //Это лямбда-выражение представляет операцию, которая будет выполнена для каждого элемента массива


    static void MyArrayElements(int[] arr)
    {
        Console.WriteLine("Введите 8 элементов массива:");

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
