using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Please enter 2 numbers, Seperated by spaces.");
      var replyNumbers = Console.ReadLine();
            var data = replyNumbers.Split();
            double numberOne = Convert.ToInt32(data[0]);
            double numberTwo = Convert.ToInt32(data[1]);

        if (numberOne > numberTwo){
            Console.WriteLine($"The larger number is {numberOne}");
            }
        else if (numberTwo > numberOne){
            Console.WriteLine($"The larger number is {numberTwo}");
            }
        else {
            Console.WriteLine("They are equal!");
            }
    }
  }
}
