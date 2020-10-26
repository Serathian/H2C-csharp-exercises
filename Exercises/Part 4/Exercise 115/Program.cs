using System;
using System.Security.Cryptography.X509Certificates;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
        bool run = true;
            
            while (run == true)
	        {
            string useless = (Console.ReadLine());
                    if (useless == "end")
	                {
                        run = false;
                            break;
	                }
            int x = Convert.ToInt32(useless);
            Console.WriteLine((x * x) * x);
            }
    }
  }
}
