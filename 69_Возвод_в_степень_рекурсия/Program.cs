Console.Clear();

int Step(int digit, int square)
{
    if(square == 1)
    {
        return digit;
    }
    else
    {
        return digit * Step(digit, square-1);
    }
}

int result = Step(3, 3);
System.Console.WriteLine(result);