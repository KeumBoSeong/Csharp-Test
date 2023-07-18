using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationTestArr
{//주어진 정수 배열에서 선택할 수 있는 모든 조합을 생성하는 C# 코드를 작성해 보세요.
 //이 때, 선택해야 하는 요소의 수를 지정할 수 있어야 합니다.
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[4];
            int[] arr2 = new int[4];
            int[] arr3 = new int[4];
            Console.Write("요소의 수를 입력하세요. :");
            string a = Console.ReadLine();
            if (a == "2")
            {
                for (int i = 0; i < 4; i++)
                {
                    arr[i] = i;
                    for (int j = 0; j < 4; j++)
                    {
                        arr2[j] = j;
                        if (arr[i] != arr2[j])
                        {
                            Console.WriteLine($"{arr[i] + 1} {arr2[j] + 1}");
                        }
                    }
                }
            }
            else if(a == "3")
            {
                for (int i = 0; i < 4; i++)
                {
                    arr[i] = i;
                    for (int j = 0; j < 4; j++)
                    {
                        arr2[j] = j;
                        for(int k = 0; k < 4; k++)
                        {
                            arr3[k] = k;
                            if (arr[i] != arr2[j] && arr[i] != arr3[k] && arr2[j] != arr3[k])
                            {
                                Console.WriteLine($"{arr[i] + 1} {arr2[j] + 1} {arr3[k] + 1}");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("잘못된 수를 입력하였습니다. 프로그램을 종료합니다.");
            }
            

        }
    }
}
