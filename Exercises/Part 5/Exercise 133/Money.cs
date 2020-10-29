namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
      Money newMoney = new Money(0, 0);
            // create a new Money object that has the correct worth
            newMoney.cents = this.cents + addition.cents;
            newMoney.euros = this.euros + addition.euros;

            if (newMoney.cents > 99)
            {
                newMoney.euros = newMoney.euros + newMoney.cents / 100;
                newMoney.cents = newMoney.cents % 100;
            }
            // return the new Money object
            return newMoney;
    }

    public Money Minus(Money decreaser)
    {
      Money newMoney = new Money(0, 0);
            // create a new Money object that has the correct worth
            newMoney.cents = this.cents - decreaser.cents;
            newMoney.euros = this.euros - decreaser.euros;

            if (newMoney.cents > 99)
            {
                newMoney.euros = newMoney.euros - newMoney.cents / 100;
                newMoney.cents = newMoney.cents % 100;
            }
            if(newMoney.euros < 0)
            {
                newMoney.euros = 0;
            }
            if(newMoney.cents < 0)
            {
                newMoney.cents = 0;
            }
            // return the new Money object
            return newMoney;
    }

    public bool LessThan(Money compared)
    {
      // Do something here
        if(this.euros > compared.euros)
        {
                return false;
        }
        else if (this.euros == compared.euros)
        {
            if (this.cents > compared.cents)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
                return true;
        }
    }

    public override string ToString()
    {
      string zero = "";
      if (cents < 10)
      {
        zero = "0";
      }

      return euros + "." + zero + cents + "e";
    }
  }
}
