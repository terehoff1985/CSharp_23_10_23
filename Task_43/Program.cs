/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */



int[] array = new int[4];
System.Console.Write("Задай координату точки b1:");
array[0] = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки k1:");
array[1] = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки b2:");
array[2] = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки k2:");
array[3] = int.Parse(Console.ReadLine());
double userb1 = array[0];
double userk1 = array[1];
double userb2 = array[2];
double userk2 = array[3];
double First = userb2 - userb1; 
double Second = userk1 - userk2; 

double[] SumResult(double userk1, double userb1, double First, double Second )
{
    double x_intersection = (First) / (Second);
    double y_intersection = userk1 * x_intersection + userb1;
    return new double[] { x_intersection, y_intersection }; /* (x_intersection, y_intersection); */
}
    double[] result = SumResult(userk1, userb1, First, Second);
    System.Console.WriteLine($"Результат: x={result[0]}, y={result[1]}");