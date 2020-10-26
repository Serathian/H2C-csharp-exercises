using System;

namespace exercise_106
{
	public class PaymentCard
	{
		private double Balance;

		public PaymentCard(double openingBalance)
		{
			this.Balance = openingBalance;
		}

        public override string ToString()
        {
			return $"The card has a balance of {this.Balance} euro";
        }
    }
}
