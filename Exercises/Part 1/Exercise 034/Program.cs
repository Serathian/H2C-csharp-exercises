using System;
using System.Linq.Expressions;

namespace exercise_34
{
  class Program
  {
       
    public static void Main(string[] args)
    {
      // Write your code here:
      bool userStatus = true;

            while(userStatus = true){
            
            Console.WriteLine("Do you want to continue?");
            string reply = Console.ReadLine();
                if (reply == "no"){
                    userStatus = false; 
                    Environment.Exit(1);
                }
                else{
                   
                }
                
            }
    }
  }
}
