// На вход программы подаются три целых положительных числа. Определить ,
// является ли это сторонами треугольника. Если да, то вывести всю информацию по нему  
//- площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
Console.WriteLine("Введите три целых положительных числа (стороны треугольника)");
Console.Write("Первое число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
double c = Convert.ToInt32(Console.ReadLine());
if (a+b>c && b+c>a && c+a>b)
    {
        double P = a+b+c;
        double S = Math.Round(Math.Sqrt(P/2*(P/2-a)*(P/2-b)*(P/2-c)),2);
        double cornerA = Math.Round(Math.Acos((b*b+c*c-a*a)/(2*b*c))*180/Math.PI,2);
        double cornerB = Math.Round(Math.Acos((a*a+c*c-b*b)/(2*a*c))*180/Math.PI,2);
        double cornerC = Math.Round(Math.Acos((b*b+a*a-c*c)/(2*b*a))*180/Math.PI,2);
        Console.WriteLine($"Площадь треугольника= {S}, Периметр= {P} УголА= {cornerA} УголB= {cornerB} УголC= {cornerC}");
        if (cornerA==90 || cornerB==90 || cornerC==90) Console.WriteLine("Треугольник прямоугольный");
        if (a==b && b==c){ Console.WriteLine("Треугольник равносторонний");}
        else 
            {
                if (a==b || b==c || a==c) Console.WriteLine("Треугольник равнобедренный");
            }
    }
else Console.WriteLine("Это не треугольник");

