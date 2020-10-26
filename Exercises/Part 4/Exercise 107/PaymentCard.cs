using System;

namespace exercise_107
{
	public class PaymentCard
	{
		private double Balance;

		public PaymentCard(double openingBalance)
		{
			this.Balance = openingBalance;
		}

        public void EatLunch()
        {
            double lunch = 10.6;
			if (this.Balance >= lunch)
            {
                this.Balance = this.Balance - lunch;
            }
        }

        public void DrinkCoffee()
        {
            double coffee = 2;
            if (this.Balance >= coffee)
            {
                this.Balance = this.Balance - coffee;
            }
        }
        public override string ToString()
        {
			return $"The card has a balance of {this.Balance} euro";
        }
    }
}
