using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepotionApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 4; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally // 무조건 실행하는 문법 , 예외의 유무에 관계없이 무조건 동작 시킴
            {
                Console.WriteLine("무조건 실행 : finally");
            }
        }
    }
}
