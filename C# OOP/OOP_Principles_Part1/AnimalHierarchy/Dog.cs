
namespace AnimalHierarchy
{
    using System;

    public class Dog: Animal
    {

        public Dog(string name, GenderValue gender, int age)
            : base(name, gender, age)
        {
 
        }

        public override void MakeSound()
        {
            Console.WriteLine("Say Bau.");
        }
    }
}
