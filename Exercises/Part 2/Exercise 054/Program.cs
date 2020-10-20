using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      DivisibleByThreeInRange(3, 10);
    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int beg, int end){
        for(int i = beg; i <= end; i++){
            if(i%3 == 0){
                Console.WriteLine($"{i}");
                }
            
            }
        return;
        }
  }
}
