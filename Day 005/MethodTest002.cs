using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest002
{
    class MyApp
    {
        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        //Min Method
        public int Min(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }
    }
    internal class Program
    {

        // 두 수를 입력 받아 큰 수 및 작은 수를 출력
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            Console.WriteLine(app.Max(100, 200));
            Console.WriteLine(app.Min(100, 200));
        }
    }
}
