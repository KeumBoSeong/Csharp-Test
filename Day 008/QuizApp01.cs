using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp01
{ // 문자열을 Console.ReadLine()을 입력 받아 뒤집어서 출력
// Ex) Hello olleH
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] array = input.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine(array);

        }
    }
}
