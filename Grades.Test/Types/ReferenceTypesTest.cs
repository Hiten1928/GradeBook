using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
   public class ReferenceTypesTest
    {
        public ReferenceTypesTest()
        {
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
