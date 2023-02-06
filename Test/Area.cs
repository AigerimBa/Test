namespace Test
{
    public class Area
    {
        // Площадь окружности (S= r2*П)
        public double Circle(double r)
        {
            double p = 3.1415;
            if (r == 0 || r < 0)
                throw new ArgumentException("Не правильный ввод.");

            double s1 = Math.Pow(r, 2) * p;
            return s1;
        }

        public (double, string) Triangle(double a, double b, double c)
        {// Площадь треугольника (P=(a+b+c)/2; S=№(p * (p - a) * (p - b) * (p - c))

            if (a == 0 || b == 0 || c == 0 || a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Не правильный ввод.");

            double p = (a + b + c) / 2;
            double s2 = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return (s2, RightTriangle(a, b, c));
        }

        public string RightTriangle(double a, double b, double c)
        {//Проверку на то, является ли треугольник прямоугольным (Для определения типа треугольника воспользуемся теоремой Пифагора.
         //Если теорема Пифагора будет верна, и квадрат большей стороны треугольника равен сумме квадратов двух меньших сторон, то треугольник прямоугольный)
           
            string IsTriangle;
            if (a == 0 || b == 0 || c == 0 || a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Не правильный ввод.");

            if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) || (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2)) || (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)))
                IsTriangle = "прямоугольный треугольник";
            else
                IsTriangle = "не прямоугольный треугольник";

            return IsTriangle;
        }
    }
}