using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      Division(7,2);

    }

    // Write your method here:
    public static void Division(int num, int den){

        double x = Convert.ToDouble(num) / Convert.ToDouble(den);
        Console.WriteLine($"{x}");
            return;
        }
  }
}
