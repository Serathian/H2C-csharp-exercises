using System;

namespace Exercise_095
{
	public class Dog
	{
		private string Name;
		private string Breed;
		private int Age;


		public Dog(string name, string breed, int age)
		{
			this.Name = name;
			this.Breed = breed;
			this.Age = age;
		}

        public void PrintInfo()
        {
			Console.WriteLine(Name, Breed, Age);
        }
    }
}