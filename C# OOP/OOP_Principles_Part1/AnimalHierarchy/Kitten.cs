
namespace AnimalHierarchy
{
    using System;

    public class Kitten: Cat
    {
        public Kitten(string name, int age)
            :base(name,age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = GenderValue.female;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kitten Miau.");
        }


    }
}
