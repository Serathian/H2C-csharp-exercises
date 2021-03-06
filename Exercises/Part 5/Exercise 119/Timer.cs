﻿using System;
using System.Dynamic;

public class Timer
{
    private int Seconds { get; set; }
	private int SecondsLimit = 60;
    private int Miliseconds { get; set; }
	private int MilisecondsLimit = 100;

	public Timer()
	{

	}

	public void Advance()
    {
		this.Miliseconds++;
        if (this.Miliseconds >= this.MilisecondsLimit)
        {
            this.Miliseconds = 0;
			this.Seconds++;
            if (this.Seconds >= this.SecondsLimit)
            {
				this.Seconds = 0;
            }
			else
            {
				
            }
        }
		else
        {
			
        }
    }

    public override string ToString()
    {
        return this.Seconds.ToString("00") + ":" + this.Miliseconds.ToString("00");
    }
}
