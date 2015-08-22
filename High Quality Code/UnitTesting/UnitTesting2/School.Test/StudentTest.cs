namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTest
    {
        private string validStudentName = "Martin";
        private int validStudentNumber = 10001;

        [TestMethod]
        public void TestCreatingStudentNotToThrow()
        {
            Student newstudent = new Student(validStudentName,validStudentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InvalidStudentNumberShouldTrhow()
        {
            var newStudent = new Student(validStudentName,9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStudentNameShouldTrow()
        {
            string invalidStudentName = "";
            var newStudent = new Student(invalidStudentName, validStudentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStudentNameShouldTrow()
        {
            string invalidStudentName = null;
            var newStudent = new Student(invalidStudentName, validStudentNumber);
        }

        [TestMethod]
        public void 
    }
}
