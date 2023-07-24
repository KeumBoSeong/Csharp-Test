using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConverterTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("실수를 입력하세요");
            double i = double.Parse(Console.ReadLine());
            
            byte[] doubleBytes = BitConverter.GetBytes(i);
            double doubleResult = BitConverter.ToDouble(doubleBytes, 0);
            Console.WriteLine(BitConverter.ToString(doubleBytes));
            Console.WriteLine(doubleResult);
        }
    }
}
