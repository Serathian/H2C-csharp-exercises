using System;

namespace exercise_113
{
  public class Book
  {
    public string Name { get; set; }
    public int NumPages { get; set; }
    public int PubYear { get; set; }

    public Book(string name = "unknown", int numPages = 0, int pubYear = 0000)
	{
        this.Name = name;
        this.NumPages = numPages;
        this.PubYear = pubYear;
	}

    public override string ToString()
    {
        return this.Name + ", " + this.NumPages + " pages, " + this.PubYear;
    }
    }
}