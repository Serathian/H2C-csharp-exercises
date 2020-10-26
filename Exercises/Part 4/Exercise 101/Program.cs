using System;

namespace exercise_101
{
  class Program
  {
    public static void Main(string[] args)
    {
      Dalmatian spotty = new Dalmatian("Spot", 306);
      Console.WriteLine(spotty.Name + " is a very good dog. He has " + spotty.Spots + " darker spots in his fur");
    }
  }
}



