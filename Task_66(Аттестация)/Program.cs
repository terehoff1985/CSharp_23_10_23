/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. */

 Console.Clear();


int DigitDiapas (int N, int M)
{
    if(N > M)
    {
        return 0;
    }
    else
    {
        return N + DigitDiapas(N + 1, M);
    }
}
int result = DigitDiapas(4,8);
System.Console.WriteLine(result);