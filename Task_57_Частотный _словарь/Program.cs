/* Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных. */


    int[,] GetRnd(int rows, int colom)
{
int[,] array = new int[rows, colom];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(0, 10);
}
}
return array;
}

int[,] testArray = GetRnd(5, 5);

for (int i = 0; i < testArray.GetLength(0); i++)
{
for (int j = 0; j < testArray.GetLength(1); j++)
{
Console.Write(testArray[i, j] + " ");
}
Console.WriteLine();
}


PrintElementsCount(testArray);



void PrintElementsCount(int[,] arr)
{
List<int> list = new List<int>();


foreach (int item in arr)
{
if (!list.Contains(item))
{
int count = 0;
foreach (int check item in arr)
{
if (item == check item) count++;
}

System.Console.WriteLine(item + " встречается " + count + " раз");
}
list.Add(item);
}
}
