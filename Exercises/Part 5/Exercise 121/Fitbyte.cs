using System;

public class Fitbyte
{
    public int Age { get; set; }
    public int RestingHeartRate { get; set; }
    public double MaxHeartRate { get; set; }

    public Fitbyte(int age, int restingHeartRate)
	{
        this.Age = age;
        this.RestingHeartRate = restingHeartRate;
        this.MaxHeartRate = 206.3 - (0.711 * this.Age);
	}

    public double TargetHeartRate(double percentageOfMaximum)
    {
        double heartRate = (this.MaxHeartRate - this.RestingHeartRate) * percentageOfMaximum + this.RestingHeartRate;
        return heartRate;
    }
}
