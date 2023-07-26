using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadOut
{
    internal class Program
    {
        static void ThreadFunc()
        {
            Console.WriteLine("5초후 종료");
            Thread.Sleep(3000);
            Console.WriteLine("스레드 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadFunc));
            t.IsBackground = true; // <= 주석 처리를 통해 비교 
            t.Start();
            // t.Join(); // <= 주석 처리를 통해 비교
            Console.WriteLine("메인 스레드 종료");
        }
    }
}


