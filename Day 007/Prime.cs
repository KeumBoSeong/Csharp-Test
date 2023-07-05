using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    // 소수 구하기
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            for(int i =2; i<=100; i++)
            {
                flag = false;
                for(int j =2; j<i; j++)
                {
                    if(i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
