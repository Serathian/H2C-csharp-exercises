using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
       int sum = 0;
      int number = 1;
      int tally = 0;
      
      while(number != sum){
                
      Console.WriteLine("Give me a number");
            number = Convert.ToInt32(Console.ReadLine());
                if(number != 0){
                tally = tally + number;}
        }
            Console.WriteLine($"Total sum of number: {tally}");
    }
  }
}
