using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int number = 1;
      int tally = 0;
      // Write your code here:
      while(number != sum){
                tally++;
      Console.WriteLine("Give me a number");
            number = Convert.ToInt32(Console.ReadLine());
        }
            Console.WriteLine($"Total number given: {tally}");
    }
  }
}
