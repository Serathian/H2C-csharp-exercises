using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace exercise_118
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask the user for the file name and print the content of the file
      Console.WriteLine("Name of the file:");
      string file = Console.ReadLine();

      // DO NOT TOUCH THE CODE ABOVE!
      // implement reading the file here;
        List<string> names = File.ReadAllLines($@"C:\Serathian\H2C-csharp-exercises\Exercises\Part 4\Exercise 118\{file}").ToList();

            foreach (string name in names) 
            {
                name.Trim();
            }
      // DO NOT TOUCH THE CODE BELOW!
      Console.WriteLine("");

      Console.WriteLine("Enter names, an empty line quits.");
      while (true)
      {
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }

        if (names.Contains(name))
        {
          Console.WriteLine("The name is on the list.");
        }
        else
        {
          Console.WriteLine("The name is not on the list.");
        }
      }

      Console.WriteLine("Thank you!");

    }
  }
}
