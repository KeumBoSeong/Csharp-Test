using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiletest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 100 ~ 1 모두 1씩 마이너스 되면서 출력하라
            // for문
            // for (초기값; 조건; 증가감)
            for (int i = 100; i > 0; i--) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
