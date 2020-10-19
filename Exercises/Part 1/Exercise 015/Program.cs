using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give me a string");
           string replyOne = Console.ReadLine();
            Console.WriteLine("Give me a integer" );
            int replyTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a double" );
            double replyThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me a boolean" );
            string replyFour = Console.ReadLine().ToLower();

            string replyBool = "null";

            if (replyFour == "true")
                {
            replyBool = "True";
            }
            else if (replyFour == "false")
                {
            replyBool = "Fasle";
                    }
            else{
            replyBool = "reply not valid";
            }


            Console.WriteLine(
                $"Your string: {replyOne} \n" + 
                $"Your integer: {replyTwo} \n" +
                $"Your double: {replyThree} \n" +
                $"Your boolean: {replyBool} \n"
                );
    }
  }
}
