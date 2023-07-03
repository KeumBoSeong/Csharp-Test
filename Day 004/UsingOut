using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOut
{

    internal class Program
    {
        static void Divide(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20, b = 3;
            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a/b : {c}    a%b : {d}");
        }
    }
}
