using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNumberConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b= a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d  =c.ToString();
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e); // 문자열을 정수로 바꿈
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);
        }
    }
}
