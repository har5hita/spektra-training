using System;
using System.Text.RegularExpressions;

namespace RemoveSpecialCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

           
            Regex regex = new Regex("[^a-zA-Z0-9_ -]");

           
            string result = regex.Replace(text, "");

            Console.WriteLine("Updated string without special characters:");
            Console.WriteLine(result);
        }
    }
}
