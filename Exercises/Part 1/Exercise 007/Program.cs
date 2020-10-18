using System;

namespace exercise_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give input!");
            // Write your code here:
           string name = Console.ReadLine();

            for (int i = 0; i < 3; i++)
                {
                Console.WriteLine("{0}", name);
            }
        }
    }
}
