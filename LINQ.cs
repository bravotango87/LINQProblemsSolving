using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class LINQ
    {
        // member variables (Has a)


        public List<string> words = new List<string>() {"the", "bike", "this", "it", "tenth", "mathematics"};
        public List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        public List<string> classGrades = new List<string>()
        {
            "80, 100, 92, 89, 65",
            "93, 81, 78, 84, 69",
            "73, 88, 83, 99, 64",
            "98, 100, 66, 74, 55"
        };

      // constructor (Spawner)

        public LINQ()
        {
            ReturnWordsWithTh(words);
            ReturnNoDuplicates(names);
            CalculateClassAverage(classGrades);

        }
     
        

     // member methods (Can do)
        
        public void ReturnWordsWithTh(List<string> words)
        {

        }

        public void ReturnNoDuplicates(List<string> names)
        {

        }

        public void CalculateClassAverage (List<string> classGrades)
        {

        }

    }
}
