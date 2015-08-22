using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsAndCourses
{
    public class Student
    {
        private const int MIN_NUMBER = 10000;
        private const int MAX_NUMBER = 99999;

        private string name;
        private int number;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name should contain at least 1 character.");
                }
                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (value < MIN_NUMBER  || MAX_NUMBER < value)
                {
                    throw new ArgumentException("Student number should be positive.");
                }
                this.number = value;
            }
        }
    }
}
