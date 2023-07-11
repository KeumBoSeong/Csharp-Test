using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopApp01
{
    class Calculator
    {
        public int SumLoop(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());    

            Calculator calculator = new Calculator();
            int result= calculator.SumLoop(start, end);
            Console.WriteLine(result);
        }
    }
}
