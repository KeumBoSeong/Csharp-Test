using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i =0; i<4; i++)
            {
                for(int j =0; j<4; j++)
                {
                    if(i != j && i < j)
                    {
                        Console.WriteLine($"{i+1} {j+1}");
                    }
                }
            }
        }
    }
}
