namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Class: IComments
    {
        public Class(string id)
        {
            this.ClassID = id;
            this.ClassTeachers = new List<Teacher>();
        }

        public string ClassID { get; set; }
        public List<Teacher> ClassTeachers { get; set; }
        public List<string> Comment { get; set; }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        } 


    }
}
