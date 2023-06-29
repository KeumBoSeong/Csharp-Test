using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문_단을_입력받은_구구단_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 단을 입력받은 구구단
             Ex) 단을 입력하세요 : 5
             5 * 1 = 5
             5 * 2 = 10
             .
             .
             .
            */

            int num;
            Console.WriteLine($"숫자를 입력하세요");
            num = int.Parse( Console.ReadLine() );
            switch(num)
            {
                case 3:
                    for (int i = 3; i <= 3; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} * {j} = {i * j}");
                        }
                    }
                    break;
                case 4:
                    for (int i =4; i <=4; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} * {j} = {i * j}");
                        }
                    }
                    break;
                case 5:
                    for (int i = 5; i <= 5; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} * {j} = {i * j}");
                        }
                    }
                    break;
                case 6:
                    for (int i = 6; i<= 6; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} * {j} = {i * j}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine($"Error");
                    break;
            }
        }
    }
}
