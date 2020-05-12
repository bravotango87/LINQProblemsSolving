using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class LINQ
    {
        // member variables (Has a)


        public List<string> wordslist = new List<string>() {"the", "bike", "this", "it", "tenth", "mathematics"};
        public List<string> nameslist = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        public List<string> classGrades = new List<string>()
        {
            "80, 100, 92, 89, 65",
            "93, 81, 78, 84, 69",
            "73, 88, 83, 99, 64",
            "98, 100, 66, 74, 55"
        };

      // constructor (Spawner)

      
        

     // member methods (Can do)
       
            
        // 1. write a function that returns "th" from the list.
        public void ReturnWordsWithTh(List<string> words)
        {
            var word = words;
            var ThWord = word.Where(w =>w.Contains("th"));
           
            foreach (var wo in ThWord)
            {
                Console.WriteLine(wo);
                
            }
            

        }

        // 2. write function that returns copy of list with no duplicates (last mike needs ti be gone)
        public void ReturnNoDuplicates(List<string> names)
        {
            var name = names;
            var removeNames = name.Distinct();

            foreach (var namess in removeNames)
            {
                Console.WriteLine(namess);
                
                
            }

        }

        public void CalculateClassAverage (List<string> classGrades)
        {

        }

    }
}
