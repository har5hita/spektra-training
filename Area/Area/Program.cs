namespace Area
{
    internal class Program
    {
        public abstract class shape
        {
            public abstract double area();
        }

        public class Circle : shape
        {
            private double r;
            
            public Circle(double radius)
            {
                r = radius;
            }
            public override double area()
            {
                return (3.14*r*r);
            }
        }
        public class Square : shape
        {
            private double a;
            public Square(double side)
            {
                a=side;
            }
            public override double area()
            {
                return (a*a);
            }
        }
        public class Triangle : shape
        {
            private double bases, height;
            public Triangle(double b, double h)
            {
                bases = b;
                height = h;
            }
            public override double area()
            {
                return (.5*bases*height);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle:");
            double r=Convert.ToDouble(Console.ReadLine());
            Circle c = new Circle(r);
            Console.WriteLine("Enter side of a square:");
            double a=Convert.ToDouble(Console.ReadLine());  
            Square s = new Square(a);
            Console.WriteLine("Enter base of triangle:");
            double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of triangle:");
            double h=Convert.ToDouble(Console.ReadLine());
            Triangle t = new Triangle(b, h);

            Console.WriteLine("Area of Circle:" + c.area());
            Console.WriteLine("Area of Square:"+s.area());
            Console.WriteLine("Area of triangle:"+t.area());
        }
    }
}
