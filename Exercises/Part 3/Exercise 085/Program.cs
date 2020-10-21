using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
            bool correctLogin = false;
            string currentUser = "Hal 9000";
            
            while (correctLogin == false)
            {
                Console.WriteLine("Enter username:");
                string userName = Console.ReadLine();

                    switch (userName)
                    {
                        case "alex":
                            Console.WriteLine("Enter password:");
                            string passWordAlex = Console.ReadLine();
                        
                            if(passWordAlex == "sunshine")
                            {
                            Console.WriteLine("You have logged in!");
                            currentUser = "Alex";
                            }
                            else
                            {
                            Console.WriteLine("Incorrect username or password");
                            }
                            break;

                        case "emma":
                            Console.WriteLine("Enter password:");
                            string passWordEmma = Console.ReadLine();
                        
                            if(passWordEmma == "haskell")
                            {
                            Console.WriteLine("You have logged in!");
                            currentUser = "Emma";
                            }
                            else
                            {
                            Console.WriteLine("Incorrect username or password");
                            }
                            break;

                        default:
                            break;
                    }
              
                Console.WriteLine("HAL 9000: This mission is too important for me to allow you to jeopardize it.");
                Console.WriteLine($"User: {currentUser} will be terminated.");

                Environment.Exit(1);
            }
            

    }
        
}
}


