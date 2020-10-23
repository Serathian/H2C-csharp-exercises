using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
    
    Account heikkisAccount = new Account("Heikki's account", 100.00);
    
    heikkisAccount.Deposit(20);
    Console.WriteLine("The balance of Heikki's other account is now: " + heikkisAccount.balance);
    }
  }
    public class Account {

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



