// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Дано уравнение прямой y=k1*x+b1");
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Дано уравнение прямой y=k2*x+b2");
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
void Test() {
if (k2-k1 == 0)
    {   if (k1*b2-k2*b1 == 0 && b1-b2 == 0) Console.Write("Прямые совпадают");
        else Console.Write("Прямые параллельны");    }
else    {
        double x = (b1-b2)/(k2-k1);
        double y = (k2*b1-k1*b2)/(k2-k1);
        Console.Write($"Точка пересечения прямых ({x} ; {y})");    }   
}   Test();