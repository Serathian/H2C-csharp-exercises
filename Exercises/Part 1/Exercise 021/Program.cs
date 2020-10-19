using System;

namespace exercise_21
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

        Console.WriteLine("The average is: {0}",(numberOne + numberTwo)/ data.Length);
    }
  }
}
