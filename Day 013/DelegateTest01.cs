using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest01
{
    delegate int MyDelegate(int a, int b);
    internal class Program
    {
        class Calcuclator
        {
            public int Plus(int a, int b)
            {
                return a + b;
            }
            public int Minus(int a, int b)
            {
                return a - b;
            }
        }
        static void Main(string[] args)
        {
            Calcuclator calcuclator = new Calcuclator();
            MyDelegate Callback;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            Callback = new MyDelegate(calcuclator.Plus);
            
            Console.WriteLine(Callback(a,b));

            Callback = new MyDelegate(calcuclator.Minus);
            Console.WriteLine(Callback(a, b));
        }
    }
}
