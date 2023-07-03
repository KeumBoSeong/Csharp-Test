using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAppTest003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do While

            // 1. 무한루프를 do ~ while문으로 만듭니다.
            // 2. 정수 100을 넣으면 종료되는 프로그램
            // 3. switch ~ case 문을 작성

            do

            {
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("1이 출력되었습니다.");
                        break;
                    case 2:
                        Console.WriteLine("2이 출력되었습니다.");
                        break;
                    default:
                        Console.WriteLine("1,2 이외의 수가 출력 되었습니다.");
                        break;
                }
                if (i == 100)
                {
                    Console.WriteLine("종료");
                    Environment.Exit(0);
                }
            } while (true);
                        






        }
    }
}
