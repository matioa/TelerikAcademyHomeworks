using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTests
{
    [TestClass]
    private class StudentTest
    {
        private string validStudentName = "Martin";
        private int validStudentNumber = 10001;

        [TestMethod]
        private void TestCreatingStudentDoNotThrow()
        {
            var newstudent = new Student(); 
        }
    }
}
