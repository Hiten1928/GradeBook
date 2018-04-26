using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

             GradeBook book = new GradeBook();

            book.AddGrade(75);
            book.AddGrade(82.5f);
            book.AddGrade(97);
            book.AddGrade(12);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.Average);
            Console.WriteLine(stats.Maximum);
            Console.WriteLine(stats.Minimum);
        }
    }
}
