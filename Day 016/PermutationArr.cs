using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationArr
{
    //주어진 정수 배열에서 가능한 모든 순열을 생성하는 C# 코드를 작성해 보세요.
    //예를 들어, 입력 배열이[1, 2, 3] 이면 가능한 모든 순열은 다음과 같습니다:
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int[] arr2 = new int[3];
            int[] arr3 = new int[3];
            for(int i = 0; i<3; i++)
            {
                arr[i] = i;

                for(int j = 0; j<3; j++)
                {
                    arr2[j] = j;

                    for(int k = 0; k<3; k++)
                    {
                        arr3[k] = k;

                        if (arr[i] != arr2[j] && arr2[j] != arr3[k] && arr3[k] != arr[i])
                        {
                            Console.WriteLine($"{arr[i] + 1} {arr2[j] + 1} {arr3[k] + 1}");
                        }
                    }
                }
            }
        }
    }
}
