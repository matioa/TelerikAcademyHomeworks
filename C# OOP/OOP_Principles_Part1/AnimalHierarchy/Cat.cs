namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {
        }

        public Cat(string name, GenderValue gender, int age)
            : base(name, gender, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Say Miau.");
        }
    }
}
