using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static double Add(int x, int y)
        {

            return x + y;
        }
        static void Main(string[] args)
        {
            int value1 = 100;
            int value2 = 200;

            double result = Add(value1, value2);

            Console.WriteLine(result);
            Console.WriteLine(Add(value1, value2));


        }
    }
}
