using System;
using System.Linq;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    public static int Smallest(int x, int y){
        int[] array = { x, y };

        int min = array.Min();
                return min;
        }
  }
}
