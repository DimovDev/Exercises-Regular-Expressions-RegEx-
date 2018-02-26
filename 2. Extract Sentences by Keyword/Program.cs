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
            string pattern = @"[^A-Za-z]";
            foreach (string item in input)
            {
                string[] words = Regex.Split(item, pattern);
                if (input.Contains(word))
                {
                    Console.WriteLine(item.Trim());
                }
            }
           ;
        }
    }
}
