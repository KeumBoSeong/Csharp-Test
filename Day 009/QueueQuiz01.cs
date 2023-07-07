using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueQuiz01
{   // Quiz 1.
    // 문자열 "Hello", "Halo", "Hi"를 Queue에 입력하고 Enqueue()
    // 콘솔 화면에 출력하시오. Dequeue()

    // Quiz 2.
    // stack 이란 자료 구조 Collection
    // 입력을  Push()로 하고 출력을 Pop()


    internal class Program
    {
        static void Main(string[] args)
        {
            // Quiz 1.
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("Halo");
            queue.Enqueue("Hi");

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            // Quiz 2.
            Stack<char> stack = new Stack<char>();
            stack.Push('H');
            stack.Push('E');
            stack.Push('L');
            stack.Push('L');
            stack.Push('O');

            Console.WriteLine();
            while (stack.Count > 0)
                Console.Write(stack.Pop());
            Console.WriteLine();







        }
    }
}
