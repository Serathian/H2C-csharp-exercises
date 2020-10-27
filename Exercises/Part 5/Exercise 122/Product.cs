namespace exercise_122
{
  public class Product
  {
    // DO NOT TOUCH THESE VARIABLES
    private string Name;
    private string Location;
    private int Weight;

        // CREATE YOUR CONSTRUCTORS HERE
        public Product(string name)
        {
            this.Name = name;
            this.Location = "shelf";
            this.Weight = 1;
        }

        public Product(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Weight = 1;
        }

        public Product(string name, int weight)
        {
            this.Name = name;
            this.Location = "warehouse";
            this.Weight = weight;
        }



    // DO NOT TOUCH THIS
    public override string ToString()
    {
      return $"{this.Name} ({this.Weight} kg) can be found from the {this.Location}.";
    }
  }
}