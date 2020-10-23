using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
        Account heikkisAccount = new Account("Heikkis Account", 1000);
        Account jakesAccount = new Account("jakes Account", 0);
    
        heikkisAccount.Withdrawal(100);
        jakesAccount.Deposit(100);

            Console.WriteLine(heikkisAccount.ToString());
            Console.WriteLine(jakesAccount.ToString());
        
    }
  }
  public class Account 
  {

    public double balance { get; set; }
    private string owner;

    public Account(string owner, double balance) {
        this.balance = balance;
        this.owner = owner;
    }

    public void Deposit(double amount) {
        this.balance = this.balance + amount;
    }

    public void Withdrawal(double amount) {
        this.balance = this.balance - amount;
    }

    public override string ToString()
    {
      return this.owner + " balance: " + this.balance;
    }
  }
}



