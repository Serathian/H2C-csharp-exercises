using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information. \n" + "Give a name for main character:");
            string name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string profession = Console.ReadLine();
            Console.WriteLine("Here is the story: \n" +
                "Once upon a time there was a {0} called {1} \n" +
                "On her way to work, {1} often pondered what being {0} meant to them. \n"+
                "When you work as a {0} you meet interesting people. \n"+
                "Ada enjoys their work as {0}, The end.", profession, name);

        }
    }
}
