using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // ToLowr 대문자 -> 소문자  ToUpper 소문자 -> 대문자
            Console.WriteLine("ABC".ToLower());
            Console.WriteLine("ABC".ToUpper());

            // Insert (삽입의 0부터 시작하는 위치 , 삽입할 문자)
            Console.WriteLine("Happy Friday!".Insert(5, "Sunny"));
            // Remove (문자 삭제를 0부터 시작 할 위치, 삭제할 문자의 수)
            Console.WriteLine("I Don't Love you".Remove(2, 6));

            // Trim 데이터 정제(공백 제거)
            Console.WriteLine("     ABC     ".Trim());
            Console.WriteLine("      ABC    "); // 비교대상
        }
    }
}
