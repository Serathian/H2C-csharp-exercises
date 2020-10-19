using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give me a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number == 0){
            Environment.Exit(1);}
            else if(number <= -1){
            Console.WriteLine("Thats negative");}
            else{
            Console.WriteLine($"{number*number}");}
    }
  }
}
