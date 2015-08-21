namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class People: IComments
    {
        private int age;
        public enum GenderValue { male, female };

        public People(string name, GenderValue gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public GenderValue Gender { get; private set; }
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
        public List<string> Comment { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        } 



    }
}
