using System;

namespace exercise_98
{
	public class Product
	{
		private string Name;
		private double Price;
		private int Quantity;

		public Product(string name ,double price, int quantity)
		{
			this.Name = name;
			this.Price = price;
			this.Quantity = quantity;
		}

		public void PrintProduct()
        {
			Console.WriteLine($"{Name}: price {Price}: {Quantity} pcs");
        }
	}
}
