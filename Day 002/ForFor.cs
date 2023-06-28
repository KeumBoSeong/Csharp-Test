using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 ~ 100 까지 합을 출력하라
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
