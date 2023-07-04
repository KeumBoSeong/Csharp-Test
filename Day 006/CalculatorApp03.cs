using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp03
{
    // 사칙연산을 하는 계산기 프로그램 
    class Calculator
    {
        // 메소드
        public int Plus(int x, int y)
        {
            return x + y;
        }
        public int Minus(int x, int y)
        {
            return x - y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result1 = calculator.Plus(1, 2);
            int result2 = calculator.Minus(1, 2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
