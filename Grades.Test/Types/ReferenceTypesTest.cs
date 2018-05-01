using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypesTest
    {
        public TypesTest()
        {
        }

        [TestMethod]
        public void ReferenceValueTest()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
           

            BookName(book1);

            Assert.AreEqual("Concept of Physics", book2.Name);

        }

        private void BookName(GradeBook book)
        {
            book.Name = "Concept of Physics";
         
        }

        [TestMethod]
        public void StringCompare()
        {
            string var1 = "Hiten";
            string var2 = "hiten";

            bool result = String.Equals(var1, var2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueTypesTest()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            
        }

        [TestMethod]
        public void VariablesHoldReferences()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Sample GradeBook";
            Assert.AreEqual(g1.Name, g2.Name);

        }

    }
}
