using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main()
        {
            List<Student> studentCollection = new List<Student>();
            studentCollection.Add(new Student("Panaiot", "Iotov", 4.5));
            studentCollection.Add(new Student("Nikola", "Geshov", 5));
            studentCollection.Add(new Student("Fikta", "Foteva", 5.3));
            studentCollection.Add(new Student("Alexander", "Bachvarov", 3.6));
            studentCollection.Add(new Student("Georgi", "Minev", 6));
            studentCollection.Add(new Student("Grisha", "Ganev", 4));
            studentCollection.Add(new Student("Iordan", "Iordanov", 2));
            studentCollection.Add(new Student("Mana", "Bachvarova", 6));
            studentCollection.Add(new Student("Limonka", "Iotova", 3));
            studentCollection.Add(new Student("Richard", "Gruev", 4.2));

            List<Worker> workersCollection = new List<Worker>();
            workersCollection.Add(new Worker("Manaf", "Borkov", 500, 40));
            workersCollection.Add(new Worker("Maria", "Manavska", 450, 38));
            workersCollection.Add(new Worker("Nikolina", "Dimitrova", 1000, 50));
            workersCollection.Add(new Worker("Sabina", "Kurteva", 300, 20));
            workersCollection.Add(new Worker("Evelina", "Koeva", 250, 35));
            workersCollection.Add(new Worker("Viktor", "Iliev", 200, 45));
            workersCollection.Add(new Worker("Sasho", "Kirov", 150, 35));

            var studentsByGrade = studentCollection.OrderBy(x => x.Grade).ToList();
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine("Name: {0} {1}, Grade: {2}",student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine(new string('=',30));
            var workersBySalary = workersCollection.OrderByDescending(x => x.MoneyPerHour()).ToList();
            foreach (var worker in workersBySalary)
            {
                Console.WriteLine("Name: {0} {1}, Money per Hour: {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            var union = studentsByGrade
                        .Select(x => new { FirstName = x.FirstName, LastName = x.LastName })
                        .Union(workersBySalary.Select(x => new { FirstName = x.FirstName, LastName = x.LastName }));

            var sortedUnion = union.OrderBy(x => x.FirstName)
                                    .ThenBy(x => x.LastName);

            Console.WriteLine("======================\nSorder Names of union lists\n");
            foreach (var person in sortedUnion)
            {
                Console.WriteLine("Name: {0} {1}", person.FirstName, person.LastName);
            }

        }
    }
}
