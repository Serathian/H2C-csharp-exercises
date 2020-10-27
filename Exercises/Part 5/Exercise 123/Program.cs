using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter();

      counter.Increase();

      Console.WriteLine(counter.Number);
    }
  }
}
