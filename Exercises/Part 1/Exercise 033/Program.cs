using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Tell me two words");
            var words = Console.ReadLine().Split(' ');
            string wordOne = Convert.ToString(words[0]);
            string wordTwo = Convert.ToString(words[1]);

        if (wordOne == wordTwo){
            Console.WriteLine("Echo!");}
        else{
            Console.WriteLine("Nope");}
    }
  }
}
