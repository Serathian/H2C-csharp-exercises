using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(Convert.ToInt32(Console.ReadLine()));
    }

    // Write your method here:
    public static void PrintFromNumberToOne(int num){
         for(int i = num; i >= 1; i--){
            Console.WriteLine($"{i}");
            }
            return;
        }
  }
}
