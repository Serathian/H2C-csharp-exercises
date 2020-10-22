using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
        while(true)
            {
                Console.WriteLine("Enter a sentance");
                
                string sentance = Console.ReadLine();
                var words = sentance.Split(' ');
                
                
                
                Console.WriteLine(words[0]);
                
            }
    }
  }
}



