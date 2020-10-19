using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
     int target = -1;
     int userNumber = 1;
     int tally = 0;
     int sum = 0;
     int evenNum = 0;  
     int oddNum = 0;       
          while(userNumber != target){
          tally++;

          Console.WriteLine("Give me a number");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber != -1){
                sum = userNumber + sum;
                if(userNumber%2 == 0){
                    evenNum++;
                }
                else{
                    oddNum++;
                }
                }
            }
                Console.WriteLine(
                    "Thx! Bye!\n" +
                    $"Total sum: {sum}\n" +
                    $"Total number given: {tally}\n" +
                    $"Average: {sum / tally}\n" +
                    $"Even: {evenNum}\n" +
                    $"Odd: {oddNum}\n"
                    );
    }
  }
}
