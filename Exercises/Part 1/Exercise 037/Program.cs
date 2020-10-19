using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int number = 1;
      // Write your code here:
      while(number != sum){
      Console.WriteLine("Give me a number");
            number = Convert.ToInt32(Console.ReadLine());
        }
    }
  }
}
