﻿using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Tell me your age.");
      int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 18){
                Console.WriteLine("You're an adult!");
            }
            else{
            Console.WriteLine("You're under age!");
                    }
    }
  }
}
