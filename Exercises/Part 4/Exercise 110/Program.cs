using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!

        List<Item> items = new List<Item>();
        bool read = true;

        while (read == true)
	    {
        string name = Console.ReadLine();
                
            if (name == "")
	        {
                read = false;
                break;
	        }
            else
	        {
                items.Add(new Item(name));
	        }
	    }

        for (int i = 0; i < items.Count; i++)
			{
             Console.WriteLine(items[i].ToString());
			}

    }
  }
}




