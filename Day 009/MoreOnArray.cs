using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnArray
{
    internal class Program
    {
        private static void Print(int value)
        {
            Console.WriteLine($"{value}");
        }
        private static bool CheckedPassed(int score)
        {
            return score >= 60;
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            int[,] scores2 = new int[2, 2];

            // 1. 정렬
            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            
            Console.WriteLine();
            // 2. Rank(배열의 차원을 반환)
            Console.WriteLine(scores.Rank + "차원");
            Console.WriteLine(scores2.Rank + "차원");

            // 3. 찾기
            Console.WriteLine($"이진탐색 81 : " + Array.BinarySearch<int>(scores, 81));

            // 4. 선형탐색 Linear Search
            Console.WriteLine($"선형탐색 81 : " + Array.IndexOf<int>(scores, 81));

            // 5. 조건 탐색
            Console.WriteLine(Array.TrueForAll<int>(scores, CheckedPassed));

            int index = Array.FindIndex<int>(scores, (score) => score >= 60);
            Console.WriteLine("index : " + index);

            // 6. 배열 크기 조정
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine("변경된 배열의 길이 : " + scores.Length);

            // 7. 배열 요소 초기화
            Array.ForEach<int>(scores, new Action<int>(Print));
            Array.Clear(scores,3, 7);
            Console.WriteLine();
            Array.ForEach<int>(scores, new Action<int>(Print));


            // 8.배열 자르기
            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Console.WriteLine();
            Array.ForEach<int>(sliced, new Action<int>(Print));

        }
    }
}
