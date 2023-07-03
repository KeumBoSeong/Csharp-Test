
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1부터 10까지 배열에 홀수만 입력되는 5크기의 arr 배열
            int[] arr = new int[5];
            //int cnt = 1;   // flag 또는 count 변수를 쓸 수 있는가
            for (int i = 0, cnt = 1; i < 5; i++, cnt += 2)
            {
                arr[i] = cnt;
                //cnt += 2;
            }
            // 화면에 출력
            for(int i =0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            // 1부터 10까지 정수가 담겨 있는 배열 arr
            // 짝수만 출력
            int[] arr2 = new int[10];
            for(int j = 0; j<10; j++)
            {
                arr2[j] = j+1;
                if (arr2[j] %2 == 0)
                {
                    Console.WriteLine(arr2[j]);
                }

            }
            Console.WriteLine();
            int[] arr3 = new int[10];
           
            for (int k = 0; k < arr3.Length; k++)
            {
                arr3[k] = k+1;
                if (arr3[k] %2 == 0)

                    Console.WriteLine(arr3[k]);
                
            }
            
        }
    }
}
