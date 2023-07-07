using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue : 앞이 열려있고 뒤가 뚫려있는 구조 123 -> 123
            Queue<int> que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }

        }
    }
}
