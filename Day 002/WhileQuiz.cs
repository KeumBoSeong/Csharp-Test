using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 200)
            {
                Console.Write(i + "  ");
                i++; // 후치연산자
            }



        }
    }
}
