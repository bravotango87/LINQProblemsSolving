using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            LINQ linq = new LINQ();

            linq.ReturnWordsWithTh(linq.wordslist);
            Console.ReadLine();
            

            

            linq.ReturnNoDuplicates(linq.nameslist);
            Console.ReadLine();

            linq.CalculateClassAverage(linq.classGrades);
            Console.ReadLine();

           


        }
    }
}
