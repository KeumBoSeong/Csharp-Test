using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type:{0}, Value:{1}", a.GetType(), a);
            Console.WriteLine($"Type:{a.GetType()}, Value: {a}");
            
        }
    }
}
