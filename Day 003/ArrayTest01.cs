using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* arr이름의 5개 요소가 있는 정수형 배열 만들기
             * 단, 배열의 요소에는 홀수 1 3 5 7 9 값이 들어감
             * 배열에 값을 담은 후 콘솔화면에 출력
             */


            int[] arr = new int[5];
            // arr[0] ~ arr[4]

            //출력
            for (int i = 0, cnt = 1; i < arr.Length; i++, cnt += 2)
            { 
                arr[i] = cnt;
                Console.WriteLine(arr[i]);
            }


        }
    }
}
