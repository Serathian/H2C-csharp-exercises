using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask the user for the file name and print the content of the file
      Console.WriteLine("Which file should have its contents printed?");
      string fileName = Console.ReadLine();
            Console.WriteLine(System.IO.File.ReadAllText($@"C:\Serathian\H2C-csharp-exercises\Exercises\Part 4\Exercise 117\{fileName}"));
      
    }
  }
}
