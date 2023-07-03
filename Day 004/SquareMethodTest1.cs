using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMethodTest1
{
    internal class Program
    {
        static double Square(double arg)
        {
            arg = arg * arg;
            return arg;
        }
        static void Main(string[] args)
        {
            //Square() 메소드를 구현해 프로그램 완성
            Console.Write("수를 입력하세요");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
