using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      
      PrintUntilNumber(Convert.ToInt32(Console.ReadLine()));

    }

    // Write your method here:
    public static void PrintUntilNumber(int startNum){
            for(int i = 1; i <= startNum; i++){
            Console.WriteLine($"{i}");
            }
            return;
        }
  }
}
