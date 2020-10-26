using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool run = true;
            int count = 0;
            while (run == true)
	{
            string useless = Console.ReadLine();
                    if (useless == "end")
	                {
                        run = false;
                            break;
	                }
            count++;
	}
    Console.WriteLine(count);    
        }
    }
}
