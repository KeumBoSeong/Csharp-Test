using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i <= 5)
            {
                Console.Write(i + " ");
                //i = i + 1;
                //i += 1;
                i++; // 후치연산자
                     // 셋 다 동일 한 표현 ( 1씩 증가 할 때)
            }
        }
    }
}
