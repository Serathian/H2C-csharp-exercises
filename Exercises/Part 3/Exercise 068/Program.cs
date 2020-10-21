using System;
using System.Collections.Generic;

namespace exercise_68
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("From where?");
            int start = list.IndexOf(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Where to?");
            int end = list.IndexOf(Convert.ToInt32(Console.ReadLine()) + 1);
            

            for(int i = start; i < end; i++){
        Console.WriteLine(list[i]);
            }
    }
  }
}
