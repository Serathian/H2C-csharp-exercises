using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine($"{i}");
            }
    }
  }
}
