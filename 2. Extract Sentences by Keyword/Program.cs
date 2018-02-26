using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] input = Console.ReadLine().Split(new char[] { '!', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries);
            string pattern =$@"\b{word}\b";
            foreach (var  item in input)
            {
               // string[] words = Regex.Split(item, pattern);
                if (Regex.IsMatch(item,pattern))
                {
                    Console.WriteLine(item.Trim());
                }
            }
           ;
        }
    }
}
