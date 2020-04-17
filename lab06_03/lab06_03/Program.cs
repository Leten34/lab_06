using System;

namespace lab06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle();
            tr1.Print();
            Console.WriteLine("Площадь: {0}", tr1.Area());
            Console.WriteLine("Периметр: {0}", tr1.Perimeter());
            Triangle tr2 = new Triangle(3, 4, 5);
            tr2.Print();
            Console.WriteLine("Площадь: {0}", tr2.Area());
            Console.WriteLine("Периметр: {0}", tr2.Perimeter());

        }
    }
    class Triangle
    {
        public int a { get; }
        public int b { get; }
        public int c { get; }
        public Triangle()
        {
            this.a = 3;
            this.b = 4;
            this.c = 5;
        }
        public static bool Existance(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && c + b > a) { return true; }
            else { return false; }
        }
        public Triangle(int a, int b, int c)
        {
            if (Existance(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else { Console.WriteLine("Неверные значения сторон!"); }
        }
        public int Perimeter()
        {
            return this.a + this.b + this.c;
        }
        public double Area()
        {
            double p = (double)this.Perimeter() / 2;
            double area = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
            return area;
        }
        public override string ToString()
        {
            string bs = String.Format("Треугольник:\n Первая сторона: {0}\n Вторая сторона: {1}\n Третья сторона: {2}", this.a, this.b, this.c);
            return bs;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}

