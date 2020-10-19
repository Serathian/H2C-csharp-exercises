using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Enter two numbers... ");
            var data = Console.ReadLine().Split(' ');
            int numOne = Convert.ToInt32(data[0]);
            int numTwo = Convert.ToInt32(data[1]);

            switch(numOne)
                {
                case int n when(n > numTwo):
                    Console.WriteLine($"{numOne} is grEater than {numTwo}");
                    break;
                case int n when(n < numTwo):
                    Console.WriteLine($"{numOne} is less than {numTwo}");
                    break;
                case int n when(n == numTwo):
                    Console.WriteLine($"{numOne} is equal than {numTwo}");
                    break;
                default:
                break;
                    }
    }
  }
}
