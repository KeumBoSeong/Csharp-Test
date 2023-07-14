using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousApp01
{
    delegate int Calculate(int a, int b);

    internal class Program
    {

        static void Main(string[] args)
        {
            Calculate Calc;

            Calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Calc(3, 4));
        }
    }
}
