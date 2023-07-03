using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest02
{
    internal class Program
    {
        static int Num(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Clear(); 
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);
            
            Console.WriteLine(Num(a, b, c, d));
            
        }
    }
}
