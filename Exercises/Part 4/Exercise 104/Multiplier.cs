using System;

namespace exercise_104
{
	public class Multiplier
	{
        public int Value { get; set; }

        public Multiplier(int value)
		{
			this.Value = value;
		}
		
		public int Multiply(int number)
        {
			int x = number * this.Value;
			return x;
        }
	}
}
