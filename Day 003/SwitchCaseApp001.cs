using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            switch (num)
            {
                case 1:
                    Console.WriteLine("1이 출력되었습니다.");
                    break;
                case 2:
                    Console.WriteLine("2이 출력되었습니다.");
                    break;
                default:
                    Console.WriteLine("기본값이 출력되었습니다.");
                    break;

            }
        }
    }
}
