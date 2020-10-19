 using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
            int num = Convert.ToInt32(Console.ReadLine());  

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i}");
            }
            
            
            Console.WriteLine("Where to?");
            int numLimit = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
            int numStart = Convert.ToInt32(Console.ReadLine());  

            for(int i = numStart; i <= numLimit; i++)
            {
                Console.WriteLine($"{i}");
            }
    }
  }
}
