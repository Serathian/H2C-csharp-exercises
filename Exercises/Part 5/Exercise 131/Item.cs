using System.Diagnostics.Eventing.Reader;

namespace exercise_131
{
  public class Item
  {

    private string identifier;
    private string name;

    public Item(string identifier, string name)
    {
      this.identifier = identifier;
      this.name = name;
    }
    public override string ToString()
    {
      return this.identifier + ": " + this.name;
    }

        public override bool Equals(object compared)
        {
            Item newItem = compared as Item;
            if (this.identifier == newItem.identifier)
            {
                return true;
            }
            else
            {
                return false;
            }
            //compare with Item.identifier
        }
    

  }
}