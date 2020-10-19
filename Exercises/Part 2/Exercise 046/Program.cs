using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = num; i <= 100; i++)
            {
                Console.WriteLine($"{i}");
            }
    }
  }
}
