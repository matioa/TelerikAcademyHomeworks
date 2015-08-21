namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Discipline: IComments
    {
        private int numberOfLectures;
        private int numberofExercizes;

        public Discipline(string name, int lectures,int excercises)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercizes = excercises;
        }

        public string Name { get; set; }
        public int NumberOfLectures {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative");
                }
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercizes
        {
            get
            {
                return this.numberofExercizes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises cannot be negative.");
                }
                this.numberofExercizes = value;
            }
        }
        public List<string> Comment { get; set; } 

        public void AddComment(string comment) 
        { 
            this.Comment.Add(comment); 
        } 

    }
}
