using System;

public class Counter
{
    public int Number { get; set; }

    public Counter()
	{
        this.Number = 0;
	}

    public Counter (int startValue)
    {
        this.Number = startValue;
    }

    public void Increase()
    {
        this.Number++;
    }

    public void IncreaseBy(int increaseBy)
    {
        if (increaseBy < 0)
        {

        }
        else
        {
            this.Number = this.Number - increaseBy;
        }
    }

    public void Decrease()
    {
        this.Number--;
    }

    public void DecreaseBy(int decreaseBy)
    {
        if (decreaseBy < 0)
        {

        }
        else
        {
            this.Number = this.Number - decreaseBy;
        }
    }
}
