namespace Methods
{
    using System;

    class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, DateTime dateOfBirth, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (!this.ValidateName(value))
                {
                    throw new ArgumentException("Last name should be between 1 and 20 characters.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (!this.ValidateName(value))
                {
                    throw new ArgumentException("Last name should be between 1 and 20 characters.");
                }
                this.lastName = value;
            }
        }

        public DateTime BirthDate { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime currentStudentBirth = this.BirthDate;
            DateTime otherStudentBirth = otherStudent.BirthDate;
            return currentStudentBirth < otherStudentBirth;
        }

        private bool ValidateName(string name)
        {
            if (name == null)
            {
                return false;
            }
            if (name.Length < 1 || name.Length > 20)
            {
                return false;
            }
            return true;
        }
    }
}

