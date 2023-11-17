 /* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
void InBinaryCode(int numb)
{
    string result = "";
    int binary = 0;
    for (int i = numb; i > 0; i/=2)
    {
        binary = i % 2;
        result = binary + result;
    }
    System.Console.Write(result);
}
InBinaryCode(2);