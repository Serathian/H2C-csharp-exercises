using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      // Write your code here:

    //Option 1
     Console.WriteLine($"{Console.ReadLine()}");
            
    //Option 2, we hope the user enters "True" or "False"
    string reply = Console.ReadLine();
    bool replyBool = Convert.ToBoolean(reply);
    Console.WriteLine(replyBool);

    //Option 3.
    string userReply = Console.ReadLine().ToLower();
    if (userReply == "true")
	{
                Console.WriteLine("True")
	}
    else if (userReply == "false")
	{
                Console.WriteLine("False")
	}
    else 
    {
                Console.WriteLine("Input not valid.")
    }
    }
  }
}
