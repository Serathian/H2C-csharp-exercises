using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("What is your grade? [0 - 100]");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade){
            
            case int n when (n < 0):
                    Console.WriteLine("Impossible");
                    break;
                    
            case int n when (n >= 0 && n <= 49):
                    Console.WriteLine("Fail");
                    break;
                    
            case int n when (n >= 50 && n <= 59):
                    Console.WriteLine("1");
                    break;
                    
            case int n when (n >= 60 && n <= 69):
                    Console.WriteLine("2");
                    break;
                    
            case int n when (n >= 70 && n <= 79):
                    Console.WriteLine("3");
                    break;
                    
            case int n when (n >= 80 && n <= 89):
                    Console.WriteLine("4");
                    break;
                    
            case int n when (n >= 90 && n <= 99):
                   Console.WriteLine("5");
                    break;
                    
            case int n when (n >= 100):
                    Console.WriteLine("Outstanding!");
                    break;
            default:
                    break;
                    
            }
    }
  }
}
