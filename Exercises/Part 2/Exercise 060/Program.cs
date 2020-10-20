using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
            PrintStars(5);
            PrintSquare(4);
            PrintRectangle(5,2);
            PrintTriangle(7);
    }


    public static void PrintStars(int number)
    {
      for(int i = 0; i < number; i++){
            Console.Write("*");}
      Console.WriteLine(" ");
    }

    public static void PrintSquare(int size)
    {
            for(int i = 0; i < size; i++){
            PrintStars(size);
            }
    }

    public static void PrintRectangle(int width, int height)
    {
             for(int i = 0; i < height; i++){
            PrintStars(width);
            }
    }
    //----I redid the code so that the triangle gets printed center and symmetrical :D----
    public static void PrintTriangle(int size)
    {
            //Calculating total size of triangle
      int bottomLine = 1;
            for(int k = 0; k < size; k++){
            bottomLine = bottomLine + 2;
            }
            //Finding middle mark
      int middleMark = (bottomLine / 2);
            //Prints the triangle.      
      for(int i = 0; i < bottomLine; i++){
                if(i%2 != 0){
                    for(int x = 1; x < middleMark; x++){
                        Console.Write(" ");}
                        middleMark--;
                PrintStars(i);}
            }      
      
           
            
    }
  }
}
