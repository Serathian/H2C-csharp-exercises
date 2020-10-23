using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
            //Creating new list of people
            List<People> people = new List<People>();

            //Creating while loop to collect data
            bool more = true;
            while(more == true)
            {
                //Grabbing data from user
                Console.WriteLine("Enter name and age... i.e Jake,27");
                var input = Console.ReadLine();

                if(input == "")
                {
                    //Calculating the maxAge of the list, I wanted to implement this as a method within class People but couldnt get it to work.
                            int maxAge = 0;
                            int indexMaxAge = 0;
                        for(int i = 0; i < people.Count; i++)
                        {
                            if(maxAge < people[i].Age)
                            {
                                maxAge = people[i].Age;
                                indexMaxAge = i;
                            }
                        }
                            
                            int maxName = 0;
                            int indexMaxName = 0;
                        for(int i = 0; i < people.Count; i++)
                        {
                            if(maxName < people[i].Name.Length)
                            {
                                maxName = people[i].Name.Length;
                                indexMaxName = i;
                            }
                        }
                    Console.WriteLine($"Longest name: {people[indexMaxName].Name}");
                    Console.WriteLine($"Highest age: {maxAge}");
                }
                else
                {
                //Splitting the data into name and age
                var data = input.Split(',');
                string name = data[0];
                int age = Convert.ToInt32(data[1]);

                //Add data to new people
                people.Add(new People(name, age));
                }
            }
            

    }
        public class People
        {
            public string Name {get; set;}
            public int Age {get; set;}

            public People(string name, int age)
            {
                this.Age = age;
                this.Name = name;
            }

            public string String()
            {
                return this.Name + ", age " + this.Age + " years";
            }
            
        }
	
  }
}



