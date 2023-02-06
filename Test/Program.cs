using Test;

Area area = new();

//Console.WriteLine("Введите радиус окружности");
//double r = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(area.Circle(r));

Console.WriteLine("Введите длинну первой стороны треугольника");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну второй стороны треугольника");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну третьей стороны треугольника");
double c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(area.Triangle(a,b,c));






