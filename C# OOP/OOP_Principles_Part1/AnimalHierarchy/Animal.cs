namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    public abstract class Animal: ISound
    {
        private int age;
        public enum GenderValue { male, female };

        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, GenderValue gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public GenderValue Gender { get; set; }
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                this.age = value;
            }
        }
        public string Name { get; set; }

        public static double AverageAge(Animal[] arr) 
         { 
             return arr.Average(x => x.Age); 
         } 
        public abstract void MakeSound();
    }
}
