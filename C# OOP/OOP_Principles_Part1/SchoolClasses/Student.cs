namespace SchoolClasses
{
    using System;

    public class Student: People
    {
        private int classNumber;

        public Student(string name, GenderValue gender, int age, int numberInClass)
            :base(name,gender,age)
        {
            this.ClassNumber = numberInClass;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("Class number cannot be negative or 0.");
                }
                this.classNumber = value;
            }
        }
    }
}
