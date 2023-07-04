using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp005
{
    class Calculator
    {
        // 1. 정수 두개를 합산하는 Plus 메소드
        // 2. 정수 네개를 합산하는 Plus 메소드
        // 3. double 두개를 합산하는 Plus 메소드
        // 메소드 이름이 같기 때문에 이를 Overloading 이라고 함.
        public int Plus(int x, int y)
        {
            return x + y;
        }
        public int Plus(int x, int y, int z, int w)
        {
            return x + y + z + w;
        }
        public double Plus(double x, double y)
        {
            return x + y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Plus(100, 200));
            Console.WriteLine(calculator.Plus(3.14, 1.23));
            Console.WriteLine(calculator.Plus(100, 200, 300, 400));
        }
    }
}
