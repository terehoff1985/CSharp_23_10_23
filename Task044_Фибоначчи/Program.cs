/* Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
/* if(n == 1 || n == 0) System.Console.Write("0");

    if(n >= 2)
    {
        System.Console.Write("0 1 ");

        int first = 0;
        int second = 1;
        
        int third = first + second;

        int count = 3;

        while(count <= n)
        {
            third = first+second;
            first = second;
            second = third;
            count++;

            System.Console.Write(third + " ");
        }
    } */
    void Fibonachi(int numb)
{
    int[] fibonachi = new int[numb + 1];
    if (numb == 0) System.Console.WriteLine("1");
    else
    {
        for (int i = 0; i < 2; i++)
        {
            fibonachi[i] = i;
            System.Console.Write(fibonachi[i] + " ");
        }
        for (int i = 2; i < numb; i++)
        {
            fibonachi[i] = fibonachi[i - 2] + fibonachi[i - 1];
            System.Console.Write(fibonachi[i] + " ");
        }
    }


}

Fibonachi(15);