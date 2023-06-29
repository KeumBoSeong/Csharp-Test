using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for문으로 13의 배수를 100 부터 1 까지 작아지는 순으로 작성
            for(int i = 100; i>0; i--)
            {
                if (i %13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
