using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp02
{
    internal class Program
    {
        static void Run()
        {
            for(int i=0; i<=100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("스레드 프로그램 종료");
        }
        static void Main(string[] args)
        {
            //Thread를 이용해서 1~100 까지 출력하는 프로그램 작성
            Thread t = new Thread(new ThreadStart(Run));
            // new ThreadStart는 생략이 가능함
            t.Start();
            t.Join();

            Console.WriteLine("Main 프로그램 종료");
        }
    }
}
