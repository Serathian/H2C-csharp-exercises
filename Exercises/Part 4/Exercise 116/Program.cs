using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Read the file data.txt and print the text from it as it is
      // You can use either File.ReadAllText or File.ReadAllLines
      string text = System.IO.File.ReadAllText(@"C:\Serathian\H2C-csharp-exercises\Exercises\Part 4\Exercise 116\data.txt");
            Console.WriteLine(text);
    }
  }
}
