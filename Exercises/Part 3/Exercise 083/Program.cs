using System;
using System.Collections.Generic;

namespace exercise_83
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("Give a word");
            string word = Console.ReadLine();
            int writeTimes = 0;

            while(writeTimes < 3)
            {
            Console.Write(word);
            writeTimes++;
            }

    }

  }
}

