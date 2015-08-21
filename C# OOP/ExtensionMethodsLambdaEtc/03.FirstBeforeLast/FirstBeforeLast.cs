using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class FirstBeforeLast
    {
        static void Main()
        {
            List<Student> studentCollection = new List<Student>();

            studentCollection.Add(new Student("Dobromir", "Gadev", 23));
            studentCollection.Add(new Student("Georgi", "Pisanchev", 24));
            studentCollection.Add(new Student("Misho", "Lisev", 25));
            studentCollection.Add(new Student("Alexander", "Chukov", 22));
            studentCollection.Add(new Student("Drajka", "Hlabava", 27));
            studentCollection.Add(new Student("Blago", "Tachev", 30));

            //Problem 3 - First Before Last
            PrintSeparator("Problem 3 - First before Last");

            var firstBeforeLast = studentCollection
                                .Where(x => x.FirstName.First().CompareTo(x.LastName.First()) < 0)
                                .ToList();
            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 4 - Age range
            PrintSeparator("Problem 4 - Age range");

            var studentsInAgeRange = studentCollection
                                .Where(s => s.Age >= 18)
                                .Where(s => s.Age <= 24)
                                .Select(st => new { st.FirstName, st.LastName })
                                .ToList();
            foreach (var student in studentsInAgeRange)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 5 - Order Students - Linq & Lambda    
            PrintSeparator("Problem 5 - Order Students - Link & Lambda");

            var orderedStudentsLinq = studentCollection
                                    .OrderByDescending(x => x.FirstName)
                                    .ThenByDescending(x => x.LastName)
                                    .ToList();

            foreach (var student in orderedStudentsLinq)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 5 - Order Students - Linq  
            PrintSeparator("Problem 5 - Order Students - Link");
            var orderedStudents =
                from student in studentCollection
                orderby student.FirstName descending,
                student.LastName descending
                select student;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
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
