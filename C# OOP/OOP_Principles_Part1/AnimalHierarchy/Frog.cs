﻿namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, GenderValue gender, int age)
            : base(name, gender, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Say Kwak");
        }
    }
}
