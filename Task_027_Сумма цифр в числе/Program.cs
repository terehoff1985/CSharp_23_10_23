/* Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе. */



System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] a = new string[N];
int count = SummNumberCount(N);
System.Console.WriteLine($"Cумма чисел равна {count}");

int SummNumberCount(int num)
{
    if (num < 10)
    {
        System.Console.WriteLine("Цифр меньше двух!!!");
    }
    else
    {
        int result = 0;
        while (num > 0)
        {
            int digit = num % 10;
            result += digit;
            num /= 10;
        }
        return result;
    }
   
}
