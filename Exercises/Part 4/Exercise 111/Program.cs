using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();
      bool read = true;

        while (read == true)
	    {
        Console.WriteLine("Enter first name:");
        string firstName = Console.ReadLine();
                if (firstName == "")
	        {
                read = false;
                break;
	        }
        Console.WriteLine("Enter last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter ID number:");
        string idNumber =Console.ReadLine();

        list.Add(new PersonalInformation(firstName, lastName, idNumber));
	    }

        Console.WriteLine();
        for (int i = 0; i < list.Count; i++)
			{
             Console.WriteLine($"{list[i].firstName} {list[i].lastName}");
			}
        
    }
  }
}




