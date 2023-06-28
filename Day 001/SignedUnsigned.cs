using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SignedUnsigned
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;  // 강제 형(type) 변환

            Console.WriteLine(b);
            uint c = uint.MaxValue; //4294967295
            int d = int.MinValue;
            Console.WriteLine($"{c} {d}");

            float e = 3.141592f;
            double f = 3.141592;
            
           
        }
    }
}
