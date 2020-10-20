using System;
using System.Linq;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int x, int y, int k){
        int[] array = { x, y, k };

        int min = array.Max();
                return min;
        }
  }
}
