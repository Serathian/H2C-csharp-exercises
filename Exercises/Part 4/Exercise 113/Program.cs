using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
        List<Book> books = new List<Book>();
        bool run = true;

            while (run == true)
	        {
            Console.Write("Name:");
            string name = Console.ReadLine();

                if (name == "")
	            {
                    run = false;
                    break;
	            }
            Console.Write("Pages:");
            int pages = Convert.ToInt32(Console.ReadLine());
            Console.Write("Publication year:");
            int pubYear = Convert.ToInt32(Console.ReadLine());

            books.Add(new Book(name, pages, pubYear));
	        }

            Console.WriteLine();

            Console.WriteLine(
                "What information will be printed? \n" +
                "1. Everything. \n" +
                "2. Title. \n"
                );
            string print = Console.ReadLine().ToLower();
            int index = 3;
            if (print.Contains("1") | print.Contains("everything") == true) 
            {
                index = 1;
            }
            else if (print.Contains("2") | print.Contains("Title") == true)
	        {
                index = 2;
	        }
            else
	        {
                index = 3;
	        }

            switch (index)
	        {
                case 1:
                    for (int i = 0; i < books.Count; i++)
			        {
                        Console.WriteLine(books[i].ToString());
			        }
                    break;
                case 2:
                    for (int i = 0; i < books.Count; i++)
			        {
                        Console.WriteLine(books[i].Name);  
                        
			        }
                    break;
		        default:
                    break;
	        }


    }
  }
}




