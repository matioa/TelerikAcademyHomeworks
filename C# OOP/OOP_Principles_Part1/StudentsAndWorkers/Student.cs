
namespace StudentsAndWorkers
{
    using System;

    public class Student: Human
    {
        private double grade;

        public Student(string firstName, string lastName, double studentGrade)
            :base (firstName, lastName)
        {
            this.Grade = studentGrade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 1 and 6.");
                }
                this.grade = value;
            }
        }

        public override void PrintName()
        {
            Console.WriteLine("{0} {1}", this.FirstName, this.LastName);
        }

    }

}
