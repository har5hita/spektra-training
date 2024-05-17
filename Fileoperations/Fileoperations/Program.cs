using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\harsh\\Desktop\\web.txt";

        if (!File.Exists(filePath))
        {
            
            File.Create(filePath);
            Console.WriteLine("File created at: "+filePath);
        }

        string existingContent = File.ReadAllText(filePath);
        Console.WriteLine("Existing Content:\n"+existingContent);

        Console.WriteLine("Enter the content to append:");
        string newContent = Console.ReadLine();

        File.AppendAllText(filePath, newContent);
        Console.WriteLine("Content appended successfully.");
        Console.WriteLine(newContent);

        string updatedContent=File.ReadAllText(filePath);
        Console.WriteLine("Final contents of file:");
        Console.WriteLine(updatedContent);
    }

   
}
