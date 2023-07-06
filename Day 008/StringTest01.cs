using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();

            int bigCnt = 0, smallCnt = 0, numberCnt = 0, specialCnt = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i]<= 'Z')bigCnt++;
                else if (arr[i] >= 'a' && arr[i]<= 'z')smallCnt++;
                else if (arr[i] >= '0' && arr[i]<= '9')numberCnt++;
                else specialCnt++;
            }

            Console.WriteLine("알파벳 대문자"+" : "+ bigCnt);
            Console.WriteLine("알파벳 소문자"+ " : " + smallCnt);
            Console.WriteLine("숫자"+ " : " + numberCnt);
            Console.WriteLine("특수문자" + " : " + specialCnt);
        }
    }
}
