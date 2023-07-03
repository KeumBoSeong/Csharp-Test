using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopApptest002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i++); // 0 1 2 3 4 (후치 연산자)
                Console.WriteLine(++i); // 1 2 3 4 5 (전치 연산자)
                Console.WriteLine("i : " + i); // 한 줄 아래는 무조건 +1
            }
        }
    }
}
