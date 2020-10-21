using System;
using System.Collections.Generic;
using System.IO;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("search for?");
            string search = Console.ReadLine();

            if(list.Contains(search) == true)
            {            
                Console.WriteLine($"{search} was found");
            }
            else{
            Console.WriteLine($"{search} was not found!");
            }
    }
  }
}

