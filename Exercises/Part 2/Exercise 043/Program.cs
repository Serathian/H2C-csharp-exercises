using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num < 0){
            Console.WriteLine(num * -1);}
            else{
            Console.WriteLine(num);}
    }
  }
}
