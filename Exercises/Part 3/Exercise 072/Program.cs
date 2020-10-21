using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
            int currentSmallest = 0;
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break;
        }
        
        list.Add(input);
      }
      
      int smallest = 10000;
            for(int i = 0; i < list.Count; i++ )
            {
                if(list[i] < smallest)
                    {
                        smallest = list[i];
                    }
            }
            Console.WriteLine($"Smallest number is {smallest}");
            for(int i = 0; i < list.Count; i++ )
            {
                if(list[i] == smallest)
                {
                Console.WriteLine($"Found at index {i}");
                }
            }
        
    }
  }
}
