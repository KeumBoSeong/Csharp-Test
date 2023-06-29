using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1~100 사이 값 중 짝수만 출력
           for(int i =1; i<=100; i++)
            {
                if (i % 2 == 0)
                {   

                    Console.WriteLine(i);
                }
               
            }   


        }
    }
}
