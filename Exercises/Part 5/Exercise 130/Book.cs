namespace exercise_130
{


  public class Book
  {

    private string name;
    private int publicationYear;

    public Book(string name, int publicationYear)
    {
      this.name = name;
      this.publicationYear = publicationYear;
    }


    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
        Book newBook = compared as Book;
        if (this.name == newBook.name)
        {
            if (this.publicationYear == newBook.publicationYear)
	        {
                return true;
            }
            else
            {
                return false;    
            }
        }
        else
        {
        return false;
        }
            
    }
    // END SOLUTION
    }


}