namespace exercise_128
{

  using System;
    using System.Security.Cryptography.X509Certificates;

    public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    {
            bool iAmBigger;
            if(this.squares > compared.squares)
            {
                iAmBigger = true;
            }
            else
            {
                iAmBigger = false;
            }
      return iAmBigger;
    }

    private int Price()
    {
            int price = this.pricePerSquare * this.squares;
            return price;
    }

    public int PriceDifference(Apartment compared)
    {
            // Math.Abs returns the absolute value
            int houseOne = this.Price();
            int houseTwo = compared.Price();
            int priceDif = houseOne - houseTwo;
      return Math.Abs(priceDif);
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
            bool iAmExpensive;
            if (this.Price() > compared.Price())
            {
                iAmExpensive = true;
            }
            else
            {
                iAmExpensive = false;
            }
            return iAmExpensive;
        }
  }

}
