using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_연도_나이
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 태어난 연도를 입력하면 한국 나이를 출력 해 주는 프로그램
            int year, age;
            year = int.Parse(Console.ReadLine());

            age = 2023 - year;
            Console.WriteLine(age+1);
            Console.WriteLine($"만{age}세");
        }
    }
}
