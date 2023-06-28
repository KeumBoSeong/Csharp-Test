using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = '반';
            char b = '가';
            char c = '워';
            char[] greet = new char[3];
            greet[0] = '반';
            greet[1] = '가';
            greet[2] = '워';

            for (int i = 0; i < greet.Length; i++)
            {
                Console.WriteLine(greet[i]);
            }

            Console.WriteLine($"{a} {b} {c}");

            string result;
            result = ("행복\n하세\n요!!!");
            Console.WriteLine(result);
        }
    }
}
