using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsAndCourses
{
    public class Course
    {
        private string name;
        private List<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Course name cannot be empty string");
                }
                this.name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student studentToAdd)
        {
            if (studentToAdd == null)
            {
                throw new ArgumentNullException("You are trying to add null as a student to student list");
            }

            this.students.Add(studentToAdd);
        }

        public void RemoveStudent(Student studentToRemove)
        {
            if (studentToRemove == null)
            {
                throw new ArgumentNullException("You are trying to add null as a student to student list");
            }
            this.students.Remove(studentToRemove);
        }
    }
}
