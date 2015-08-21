namespace AnimalHierarchy
{
    using System;
    public class TomCat: Cat
    {
        public TomCat(string name, int age)
            :base(name,age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = GenderValue.male;
        }
        public override void MakeSound()
        {
            Console.WriteLine("TomCat Miau.");
        }
    }
}
