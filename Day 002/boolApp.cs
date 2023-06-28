using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace boolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // True or False 
            bool a = true;
            bool b = false;

            
            Console.WriteLine(a);
            Console.WriteLine(b);
            

            // object 는 사용자 정의 Type 특수한 Class
            object c = 123; 
            Console.WriteLine(c);

            object d = 3.141592;
            Console.WriteLine(d);

            object e = "안녕하세요";
            Console.WriteLine(e);

            // boxing & unboxing
            object f = 20; // f는 stack 메모리에 있음
            int g = 123;
            int h = (int)f;

        }
    }
}
