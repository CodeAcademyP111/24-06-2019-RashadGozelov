using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Salam Sirvan";
            StringBuilder lastResult = Word(sentence);
            Console.WriteLine(lastResult);

        }


        static StringBuilder Word(string words)
        {
            string[] word = words.Split(' ');
            StringBuilder result = new StringBuilder();
            foreach (var item in word)
            {
                if (word[0] != item)
                {
                    result.Append(" ");
                }
                for ( int i=item.Length-1; i>=0; i-- )
                {
                    result.Append(item[i]);
                }              
            }
             return result;
        }
    }
}
