
namespace StudentsAndWorkers
{
    using System;

    public class Worker: Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workhours)
        :base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workhours;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week Salary cannot be negative.");
                }
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value <0)
                {
                    throw new ArgumentOutOfRangeException("Work hours cannot be negative.");
                }
                this.workHoursPerDay = value;
            }
        }
        
        public decimal MoneyPerHour()
        {
            double hoursPerWeek = 7*this.WorkHoursPerDay;
            decimal amount = 0;
            amount = this.WeekSalary / (decimal)hoursPerWeek;

            return amount;
        }

        public override void PrintName()
        {
            Console.WriteLine("{0} {1}", this.FirstName, this.LastName);
        }
    }

   
}
