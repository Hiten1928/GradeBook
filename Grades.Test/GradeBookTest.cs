using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTest
    
    {
        [TestMethod]
        public void TestMethod1()
        {

            GradeBook book_test = new GradeBook();

            book_test.AddGrade(10);
            book_test.AddGrade(80);

            GradeStatistics stats_test = new GradeStatistics();

            stats_test = book_test.ComputeStatistics();

            Assert.Equals(80, stats_test.Maximum);
            Assert.Equals(10, stats_test.Minimum);
            Assert.Equals(45, stats_test.Average);

        }
    }
}
