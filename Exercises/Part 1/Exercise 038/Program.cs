using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      int number = 1;
      int tally = 0;
      // Write your code here:
      while(number != sum){
                
      Console.WriteLine("Give me a number");
            number = Convert.ToInt32(Console.ReadLine());
                if(number <= -1){
                tally++;}
        }
            Console.WriteLine($"Total negative numbers given: {tally}");
    }
  }
}
