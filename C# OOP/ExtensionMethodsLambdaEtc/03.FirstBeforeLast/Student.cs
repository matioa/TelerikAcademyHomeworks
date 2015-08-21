
namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private int age;
        
        public Student(string firstName, string LastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Age = age;
            this.Marks = new List<Marks>();
            this.Tel = string.Empty;
            this.Email = string.Empty;
            this.FN = string.Empty;
            this.GroupNumber = 0;
        }

        public Student(string firstName, string LastName, int age, int newMark)
            :this(firstName, LastName, age)
        {
            this.Marks.Add(new Marks(newMark));
        }

        public Student(string firstName, string LastName, int age, string facNumber, int groupNumber)
            : this(firstName, LastName, age)
        {
            this.FN = facNumber;
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string LastName, int age, string facNumber, int groupNumber, string tel, string email)
            : this(firstName, LastName, age,facNumber,groupNumber)
        {
            this.Tel = tel;
            this.Email = email;
        }

        public List<Marks> Marks { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.age = value;
            }
        }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; set; }

        public string PrintMarks()
        {
            StringBuilder result = new StringBuilder();
            foreach (var mark in this.Marks)
            {
                result.Append(mark.Mark);
                result.Append("|");
            }
            return result.ToString();
        }

        
    }
}
