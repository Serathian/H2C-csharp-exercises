using System;

public class Debt
{
    public double InitialBalance { get; set; }
    public double InitialInterestRate { get; set; }


    public Debt(double initialBalance, double initialInterestRate)
	{
        this.InitialBalance = initialBalance;
        this.InitialInterestRate = initialInterestRate;
	}

    public void PrintBalance()
    {
        Console.WriteLine(this.InitialBalance);
    }

    public void WaitOneYear()
    {
        this.InitialBalance = this.InitialBalance * this.InitialInterestRate;
    }
}
