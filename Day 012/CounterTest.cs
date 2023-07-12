using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTest
{
//Main에서 문자열과 문자 각각 1개씩 입력받습니다.
//입력받은 문자열에 입력받은 문자가 몇개가 있는지 리턴하는 메소드를 구현해 주세요.
//함수는 다음과 유사하게 만들어 주세요.
//public int CharCounter(char[] arr, char ch)
    internal class Program
    {
        public int CharCounter(char[] arr, char ch)
        {

            int n = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ch)
                    n += 1;
            }
            return n;
            
        }
        static void Main(string[] args)
        {
            // 1. 문자열 입력
            Console.Write("문자열 : ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            // 2. 문자 입력
            Console.Write("문자 : ");
            string str2 = Console.ReadLine();
            //char c = str2[0];
            char c = str2.ElementAt(0);
            Program p = new Program();
            int result = p.CharCounter(arr, c);// Char 배열, c;
            Console.WriteLine("결과" + result);

        }
    }
}
