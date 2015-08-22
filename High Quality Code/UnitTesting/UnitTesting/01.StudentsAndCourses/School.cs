using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsAndCourses
{
    public class School
    {
        private string name;
        private List<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentException("School name should contain at least 1 character.");
                }
                this.name = value;
            }
        }
        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course courseToAdd)
        {
            if (courseToAdd == null)
            {
                throw new ArgumentNullException("You are trying to add null as a course course list");
            }

            this.courses.Add(courseToAdd);
        }

        public void RemoveCourse(Course courseToRemove)
        {
            if (courseToRemove == null)
            {
                throw new ArgumentNullException("You are trying to remove null value from courses list");
            }
            this.courses.Remove(courseToRemove);
        }

    }
}
