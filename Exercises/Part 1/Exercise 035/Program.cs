using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      bool correctNum = false;

            while(correctNum == false){
            
            Console.WriteLine("Try and guess my number...");
            int numberGuess = Convert.ToInt32(Console.ReadLine());
                if (numberGuess == 69){
                    Console.WriteLine("Good job! thats correct!");
                    correctNum = true; 
                    Environment.Exit(1);
                }
                else if(numberGuess < 69){
                Console.WriteLine("Guess a little higher");}
                else{
                Console.WriteLine("Guess a little lower");}
                }
    }
  }
}
