using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    internal class Program
    {
        //Class에 멤버 변수로 들어 간 것.
        enum DigitalResult { YES, NO, CANCEL, CONFIRM, OK };
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalResult.YES);
            Console.WriteLine((int)DigitalResult.YES);

            Console.WriteLine(DigitalResult.OK);
            Console.WriteLine((int)DigitalResult.OK);
        }
    }
}
