﻿namespace largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int largest = (n1 > n2) ? ((n1 > n3) ? n1 : n3) : ((n2 > n3) ? n2 : n3);
            Console.WriteLine("Largest of three number is:"+largest);
        }
    }
}
