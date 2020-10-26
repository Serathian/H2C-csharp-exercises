using System;

namespace exercise_102
{

	public class Gauge
	{
        public int Value { get; set; }
        
        public Gauge()
		{
            this.Value = 0;
		}

		public void Increase()
        {
            if (this.Value == 5)
            {
            }
            else
            {
                this.Value++;
            }
        }

		public void Decrease()
        {
            if (this.Value == 0)
            {

            }
            else
            {
                this.Value--;
            }
        }

		public bool Full()
        {
            if (this.Value == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	}
}
