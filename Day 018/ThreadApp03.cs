using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp03
{
    /*
     Tread 2개 만들기
     1. Thread -1 => 1~100 까지 더하기 5050출력
     2. Thread -2 => A~Z까지 알파벳 출력하기
     mainThread는 두 스레드가 종료될 때 까지 최종적으로 기다린 후 종료
     */
    internal class Program
    {
        static void Plus()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

        }
        static void Alphabet()
        {
            
            for (int i='A'; i<='Z'; i++)
            {
                
                Console.Write((char)i + " ");
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Plus);
            Thread t2 = new Thread(Alphabet);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
