using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_70
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
      //if we are using the System.Linq this is the eaiest way.
      Console.WriteLine(list.Max());
            Console.WriteLine(MaxNumberInList(list));
    }
        //Can always write a method to handle it if System.Linq isnt available.
        public static int MaxNumberInList(List<int> list){

            int maxNum = list[0];

                for(int i = 0; i < list.Count; i++) {
                    int number = list[i];
                    if (maxNum < number) {
                        maxNum = number;
                    }
                }
                return maxNum;
        }
  }
}
