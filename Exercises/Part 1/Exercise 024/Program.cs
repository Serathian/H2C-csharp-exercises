using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Your speed? enter a number..");
      int speed = Convert.ToInt32(Console.ReadLine());
            if (speed > 120){
                Console.WriteLine("Speeding!");
            }
            else{
                Console.WriteLine("Driving safe :)");
            }
           

    }
  }
}
