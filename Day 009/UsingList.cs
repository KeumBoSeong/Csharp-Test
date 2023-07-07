using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int cnt = 10;
            for(int i = 0; i < 5; i++)
            {
                // 1. 요소 추가
                list.Add(cnt);
                cnt += 10;
            }

            foreach(int n in list)
            {
                Console.Write(n + " ");
            }
            // 2. 요소 삭제
            list.RemoveAt(2);
            Console.WriteLine();
            foreach (int n in list)
            {
                Console.Write(n + " ");
            }
            // 요소삽입
            list.Insert(2, 30);
            Console.WriteLine();
            foreach (int n in list)
            {
                Console.Write(n + " ");
            }
        }
    }
}
