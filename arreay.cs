using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1may_c_program.exam
{
    internal class arreay
    {
      public  static void Main(string[] args)
        {
            string sen = "C is the programming language";

            string[] words = sen.Split(' ');

            foreach (string word in words)
            {
                if (word.Length < 4)
                {
                    Console.WriteLine(word);
                }
            }








        }
    }
}
