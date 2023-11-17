/* Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. 
Выполнить с помощью рекурсии. */
 Console.Clear();


void DigitDiapas(int number)
{
    
    if(number < 1)
    {
        return;
    }
    else
    {
        System.Console.Write(number + " ");
        DigitDiapas(number - 1);
    }
}

DigitDiapas(20);  