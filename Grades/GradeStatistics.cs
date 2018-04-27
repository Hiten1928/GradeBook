using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            Maximum = 0;
            Minimum = float.MaxValue;
        }

       public float Average;
       public float Maximum;
       public float Minimum;

    }
}
