using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
    bool run = true;
    List<TelevisionProgram> list = new List<TelevisionProgram>();

        while (run == true)
	    {
            Console.WriteLine("Name of TV show:");
            string name = Console.ReadLine();

                if (name == "")
	            {
                    run = false;
                        break;
	            }

            Console.WriteLine($"Duration of {name}:");
            int duration = Convert.ToInt32(Console.ReadLine());

            list.Add(new TelevisionProgram(name, duration));
	    }

        Console.WriteLine();
        Console.WriteLine("Program's maximum duration?:");
        int maxDuration = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
			{
                if (list[i].duration <= maxDuration)
	            {
                    Console.WriteLine(list[i].ToString());
	            }
                else
	            {

	            }
			}

    }
  }
}




