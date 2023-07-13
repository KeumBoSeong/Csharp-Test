using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    internal class Program
    {
   /*크기가 5인 정수형 배열을 만듭니다.
   메소드 Method(int size) 를 만듭니다.
   그래서 6 이상의 숫자를 입력받아 예외가 발생하면
   프로그램을 안전하게 종료할 수 있게 예외처리 하세요.*/
        static void Method(int size)
        {
            int[] arr = new int[5] {1,2,3,4,5};
            try
            {
                for(int i = 0; i<size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("정상 종료");
                
            }
            catch (Exception ex)
            
            {
                Console.WriteLine("예외발생");
                Console.WriteLine("안전 종료");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("입력 : ");
            int size = int.Parse(Console.ReadLine());
            Method(size);

        }
    }
}
