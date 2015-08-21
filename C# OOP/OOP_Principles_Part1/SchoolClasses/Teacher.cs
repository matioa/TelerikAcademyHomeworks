

namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher: People
    {
        private List<Discipline> teacherDisciplines;

        public Teacher(string name, GenderValue gender, int age)
        :base (name,gender,age)
        {
            this.TeacherDisciplines = new List<Discipline>();
        }

        public List<Discipline> TeacherDisciplines { get; set; }
    }
}
