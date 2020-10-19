using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int number = 1;
      int tally = 0;
      int totalSum = 0;
      
      while(number != sum){
                
      Console.WriteLine("Give me a number");
            number = Convert.ToInt32(Console.ReadLine());
                
                if(number != 0){
                totalSum= totalSum + number;
                tally++;}
        }
            Console.WriteLine($"Total sum of number: {totalSum}\n" +
                $"Total amount of numbers: {tally}");
    }
  }
}
