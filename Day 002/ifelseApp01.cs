using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            // 입력부 만들기
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) 
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }
            if (n > 0)
            {
                Console.WriteLine("양수");
            }
            else if (n < 0)
            {
                Console.WriteLine("음수");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
