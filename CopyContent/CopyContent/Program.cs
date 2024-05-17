using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\harsh\\Desktop\\sample.txt";

        
        if (File.Exists(filePath))
        {
            
            string existingContent = File.ReadAllText(filePath);
            Console.WriteLine("Content of "+Path.GetFileName(filePath));
            Console.WriteLine(existingContent);

           
            Console.WriteLine("\nEnter additional content to append to the file:");
            string additionalContent = Console.ReadLine();

            
            File.AppendAllText(filePath,additionalContent);
            Console.WriteLine("Additional content appended to "+ Path.GetFileName(filePath));

          
            string updatedContent = File.ReadAllText(filePath);

            
            string copiedFilePath = "copied.txt";
            File.WriteAllText(copiedFilePath, updatedContent);
            Console.WriteLine("Content copied from "+ Path.GetFileName(filePath)+" to "+copiedFilePath);

            
            string copiedContent = File.ReadAllText(copiedFilePath);
            Console.WriteLine("\nContent of "+copiedFilePath+":");
            Console.WriteLine(copiedContent);
        }
        else
        {
            Console.WriteLine("File "+filePath+" does not exist.");
        }
    }
}
