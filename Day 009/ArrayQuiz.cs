using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuiz
{
    // 배열의 크기는 80
    // 1 ~ 100 까지 수를 랜덤하게 배열에 배치
    // 처음 등장하는 숫자 '80'의 위치를 출력하고 정렬 후 다시 '80'의 위치 출력
    // 값이 없다면 "값이 없습니다" 메세지를 출력 후 종료
    
    internal class Program
    {
        static void ValueChecking (int n)
        {
            if (n < 0)
            {
                Console.WriteLine("값이 존재하지 않습니다. 프로그램을 종료합니다.");
                Environment.Exit (0);
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[80];

            for(int i = 0; i <80; i++)
            {
                arr[i] = random.Next(1, 101);
            }
            foreach (int i in arr) Console.Write(i + " ");
            Console.WriteLine();

           int n = Array.IndexOf(arr, 80);
            ValueChecking (n);
            Console.WriteLine("처음 등장한 값의 위치는" + n);
            Array.Sort(arr);
            n = Array.IndexOf(arr, 80);
            ValueChecking(n);
            Console.WriteLine("정렬 후 등장한 값의 위치는" + n);
            
        
        }
    }
}
