using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };

       
        Console.WriteLine("Accessing elements using for loop:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        
        Console.WriteLine("Accessing elements using foreach loop:");
        foreach (int n in list)
        {
            Console.WriteLine(n);
        }

        
        Console.WriteLine("Accessing elements using index:");
        Console.WriteLine("Element at index 2:"+ list[2]);
    }
}
