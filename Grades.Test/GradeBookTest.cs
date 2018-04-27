using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test
{
    [TestClass]
     public class GradeBookTest
    
    {
        [TestMethod]
        public void TestAverage()
        {

            GradeBook book_test = new GradeBook();

            book_test.AddGrade(82);
            book_test.AddGrade(123);

            GradeStatistics stats_test = new GradeStatistics();

            stats_test = book_test.ComputeStatistics();

            
            Assert.AreEqual(102.5, stats_test.Average, .01);

        }

        [TestMethod]
        public void TestHighest()
        {
            GradeBook book_test = new GradeBook();

            book_test.AddGrade(10);
            book_test.AddGrade(80);

            GradeStatistics stats_test = new GradeStatistics();

            stats_test = book_test.ComputeStatistics();

            Assert.AreEqual(80, stats_test.Maximum);
            
        }

        [TestMethod]
        public void TestLowest()
        {
            GradeBook book_test = new GradeBook();

            book_test.AddGrade(10);
            book_test.AddGrade(80);

            GradeStatistics stats_test = new GradeStatistics();

            stats_test = book_test.ComputeStatistics();

            Assert.AreEqual(10, stats_test.Minimum);
        }
    }
}
