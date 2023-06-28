using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 가로(width), 세로(height)를 입력 받아 넓이를 구합시다.
            // 단 입력은 정수 범위만 들어옴

            // 1. 변수선언 & 입력
            int width, height;
            
            width = Int32.Parse(Console.ReadLine());
            height = Int32.Parse(Console.ReadLine());
            // 2. 로직
            int result = width * height;
            // 3. 출력
            Console.WriteLine(result);
            
        }
    }
}
