using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 사용자에게 1~7 사이의 숫자를 입력받고 숫자에 따라 월요일을 출력하는 프로그램

            int day;
            Console.WriteLine($"숫자를 입력해 주세요:");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 0:
                    Console.WriteLine($"일요일 입니다.");
                    break;
                case 1:
                    Console.WriteLine($"월요일 입니다.");
                    break;
                case 2:
                    Console.WriteLine($"화요일 입니다.");
                    break;
                case 3:
                    Console.WriteLine($"수요일 입니다.");
                    break;
                case 4:
                    Console.WriteLine($"목요일 입니다.");
                    break;
                case 5:
                    Console.WriteLine($"금요일 입니다.");
                    break;
                case 6:
                    Console.WriteLine($"토요일 입니다.");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
