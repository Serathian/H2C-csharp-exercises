using System;

namespace exercise_102
{
  class Program
  {
    public static void Main(string[] args)
    {
      Gauge g = new Gauge();

      while (!g.Full())
      {
        Console.WriteLine("Not full! Value: " + g.Value);
        g.Increase();
      }

      Console.WriteLine("Full! Value: " + g.Value);
      g.Decrease();
      Console.WriteLine("Not full! Value: " + g.Value);
    }
  }
}



