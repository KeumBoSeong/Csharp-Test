using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0과 1사의 무작위 실수
            Random rand = new Random();
            double n;
            for (int i = 0; i < 5; i++)
            {
                n = rand.NextDouble();
                Console.Write(n + "\t");
            }
            Console.WriteLine();
            //특정 범위의 정수
            Random r = new Random();
            int num2;
            Console.Write($"로또번호:");
            for (int i = 0; i < 6; i++)
            {
                num2 = r.Next(1, 46); // 1부터 45까지 생성됨
                Console.Write(num2 +"\t");
            }

            int num3;
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                num3 = r.Next(1, 46);
                Console.WriteLine($"보너스 번호:{num3}");
            }
            Console.WriteLine();
        }
    }
}
