using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
            ChristmasTree(5);
    }

    public static void PrintStars(int number)
    {
            for(int i = 0; i < number; i++){
            Console.Write("*");}
      Console.WriteLine(" ");
    }

    public static void PrintSpaces(int number)
    {
            for(int i = 0; i < number; i++){
            Console.Write(" ");}
    }

    public static void PrintRightTriangle(int size)
    {

    }
        //Haha i just did this in the last one :D i didnt notice it was here.
    public static void ChristmasTree(int height)
    {
            //Calculating total size of triangle
      int bottomLine = 1;
            for(int k = 0; k < height; k++){
            bottomLine = bottomLine + 2;
            }
            //Finding middle mark
      int middleMark = (bottomLine / 2) - 1;
            //Tree base spacing
      int baseMark = middleMark - 1;
            //Prints the triangle.      
      for(int i = 0; i < bottomLine; i++){
                if(i%2 != 0){
                    PrintSpaces(middleMark);
                        middleMark--;
                PrintStars(i);}
            }
      //print base
                for(int b = 0; b < 2; b++){
                PrintSpaces(baseMark);
                PrintStars(3);}
    }
  }
}
