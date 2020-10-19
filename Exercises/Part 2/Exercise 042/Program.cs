using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        Console.WriteLine("Enter two numbers... ");
            var data = Console.ReadLine().Split(' ');
            Console.WriteLine($"{Math.Sqrt(Convert.ToInt32(data[0]))} and {Math.Sqrt(Convert.ToInt32(data[1]))} ");
    }
  }
}
