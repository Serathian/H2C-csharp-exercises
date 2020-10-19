using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        Console.WriteLine("Please enter 2 numbers, Seperated by spaces.");
      var replyNumbers = Console.ReadLine();
            var data = replyNumbers.Split();
            int numberOne = Convert.ToInt32(data[0]);
            int numberTwo = Convert.ToInt32(data[1]);

        Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, numberOne * numberTwo);
    }
  }
}
