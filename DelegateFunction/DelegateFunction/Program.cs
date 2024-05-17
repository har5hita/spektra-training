namespace DelegateFunction
{
    using System;

    public delegate double MathOperation(double a, double b);

    public class MathCalculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

        public static void PerformOperation(double a, double b, MathOperation operation)
        {
            double result = operation(a, b);
            Console.WriteLine($"Result: {result}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            MathCalculator.PerformOperation(10, 5, MathCalculator.Add);
            MathCalculator.PerformOperation(10, 5, MathCalculator.Subtract);
            MathCalculator.PerformOperation(10, 5, MathCalculator.Multiply);
            MathCalculator.PerformOperation(10, 5, MathCalculator.Divide);
        }
    }
}
