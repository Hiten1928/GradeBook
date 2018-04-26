using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {

        public GradeBook()
        {
         grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            

            float sum = 0;
            foreach(float grade in grades)
            {

                stats.Maximum = Math.Max(grade, stats.Maximum);
                stats.Minimum = Math.Min(grade, stats.Minimum);

                sum += grade;
            }

            stats.Average = sum / grades.Count;

            return stats;
        }

        public  void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        
        List<float> grades;

    }
}
