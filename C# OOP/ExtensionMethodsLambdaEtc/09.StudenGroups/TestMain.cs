using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main()
        {
            //Using the class Student defined in 03-05.Students project.
            
            List<Student> classB = new List<Student>();
            Student georgiStudent = new Student("Georgi", "Andonov", 20, "456009", 2, "8893434544", "gosheto@gmail.com");
            Student mihailStudent = new Student("Mihail", "Manov", 21, "123006", 1, "88933333", "misheto@abv.bg");
            Student alexanderStudent = new Student("Alexander", "Primorski", 2, "466008", 2);
            Student ivoStudent = new Student("Ivo", "Antonov", 23, "555005", 3, "063 23434544", "ivcho@yahoo.com");
            Student grishaStudent = new Student("Grisha", "Panchev", 20, "435005", 3, "02 44444", "grishata@abv.com");
            Student panchoStudent = new Student("Pancho", "Ganchev", 24, "231006", 2, "", "pancho@abv.bg");

            classB.Add(georgiStudent);
            classB.Add(mihailStudent);
            classB.Add(alexanderStudent);
            classB.Add(ivoStudent);
            classB.Add(grishaStudent);
            classB.Add(panchoStudent);

            georgiStudent.Marks.Add(new Marks(4));
            georgiStudent.Marks.Add(new Marks(6));
            georgiStudent.Marks.Add(new Marks(6));
            georgiStudent.Marks.Add(new Marks(5.5));
            alexanderStudent.Marks.Add(new Marks(3.5));
            ivoStudent.Marks.Add(new Marks(2));
            ivoStudent.Marks.Add(new Marks(2));
            grishaStudent.Marks.Add(new Marks(4.25));
            grishaStudent.Marks.Add(new Marks(5.60));
            panchoStudent.Marks.Add(new Marks(6));
            

            //Problem 9 - using Linq only
            PrintSeparator("Problem 9 - Student groups");
            var studentsInGroup2 =
                from student in classB
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in studentsInGroup2)
            {
                Console.WriteLine("Name: {0} - Group: {1}", student.FirstName, student.GroupNumber);
            }

           //Problem 10 - using Linq and Lambda
            PrintSeparator("Problem 10 - Student groups extensions");
            var studentsInGroup = classB
                                .Where(st => st.GroupNumber == 2)
                                .OrderBy(st => st.FirstName)
                                .ToList();

            foreach (var student in studentsInGroup)
            {
                Console.WriteLine("Name: {0} - Group: {1}",student.FirstName, student.GroupNumber);
            }

            //Problem 11 - Extract students by email
            PrintSeparator("Problem 11 - Extract students by email");
            var studentsWithABVEmai = classB
                                        .Where(st => st.Email.EndsWith("abv.bg"))
                                        .ToList();

            foreach (var student in studentsWithABVEmai)
            {
                Console.WriteLine("Name: {0} - Email: {1}",student.FirstName, student.Email);
            }

            //Problem 12 - Extract students by phone
            PrintSeparator("Problem 12 - Extract students by phone");
            var studentsPhoneInSofia = classB
                                        .Where(st => st.Tel.StartsWith("02"))
                                        .ToList();

            foreach (var student in studentsPhoneInSofia)
            {
                Console.WriteLine("Name: {0} - Tel: {1}", student.FirstName, student.Tel);
            }

            //Problem 13 - Extract students by marks
            PrintSeparator("Problem 13 - Extract students by marks");
            var excellentStudents = classB
                                    .Where(st => st.Marks.Any(m => m.Mark==6))
                                    .Select(s => new {FullName = s.FirstName+" "+s.LastName, allMarks = s.PrintMarks()})
                                    .ToList();

            foreach (var student in excellentStudents)
            {
                Console.WriteLine("Name: {0} - Marks: {1}", student.FullName, student.allMarks);
            }

            //Problem 14 - Extract students with two marks
            PrintSeparator("Problem 14 - Extract students with two marks");
            var studentsTwoMarks = classB
                                    .Where(st => st.Marks.Count(x => x.Mark==2)==2)
                                    .Select(s => new { FullName = s.FirstName + " " + s.LastName, allMarks = s.PrintMarks() })
                                    .ToList();

            foreach (var student in studentsTwoMarks)
            {
                Console.WriteLine("Name: {0} - Marks: {1}", student.FullName, student.allMarks);
            }

            //Problem 15 - Extract marks
            PrintSeparator("Problem 15 - Extract marks");
            var studentsFrom2006 = classB
                                    .Where(st => st.FN.Substring(4,2)=="06")
                                    .ToList();

            foreach (var student in studentsFrom2006)
            {
                Console.WriteLine("Name: {0} - FN: {1}", student.FirstName, student.FN);
            }

            //Problem 16* - Groups
            PrintSeparator("Problem 16* - Groups");
            List<Group> departments = new List<Group>();
            Group math = new Group(2, "Mathemathics");
            Group eng = new Group(1, "English");
            Group chem = new Group(3, "Chemistry");

            departments.Add(math);
            departments.Add(eng);
            departments.Add(chem);

            var studentsMathemathics =
                        from student in classB
                        join dep in departments on student.GroupNumber equals dep.GroupNumber
                        where dep.DepartmentName == "Mathemathics"
                        select new { Fullname = student.FirstName + " " + student.LastName, dep.DepartmentName };

            foreach (var person in studentsMathemathics)
            {
                Console.WriteLine("Student: {0} ,Department: {1}", person.Fullname, person.DepartmentName);
            }

            //Problem 18 - Grouped by GroupNumber with Linq
            PrintSeparator("Problem 18 - Grouped by GroupNumber with Linq");
            var groupedStudents2 =
                from students in classB
                group students by students.GroupNumber;


            foreach (var group in groupedStudents2)
            {
                Console.WriteLine("Group {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("Student: {0} {1}", student.FirstName, student.LastName);
                }
            }

            //Problem 19 - Grouped by GroupNumber with extension methods
            PrintSeparator("Problem 19 - Grouped by GroupNumber with extension methods");
            var groupedStudents = classB
                                    .GroupBy(st => st.GroupNumber)
                                    .ToList();

            foreach (var group in groupedStudents)
            {
                Console.WriteLine("Group {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("Student: {0} {1}", student.FirstName, student.LastName);
                }
            }

            

        }


        public static void PrintSeparator(string input)
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("---" + input + "---");
            Console.WriteLine();
        }
    }

}
