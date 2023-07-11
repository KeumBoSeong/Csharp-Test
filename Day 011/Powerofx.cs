using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerofx
{
    internal class Program
    {
        static int Pow(int x, int y)
        {
            int result = 1;
            for(int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int x = 2;
            int y = 10;

            int result = Pow(x, y);
            Console.WriteLine(result);
        }
    }
}
