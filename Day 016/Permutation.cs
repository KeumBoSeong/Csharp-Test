using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{//가능한 모든 숫자의 순열을 생성하는 C# 코드를 작성해 보세요.
//예를 들어, 1 2 3 으로 가능한 모든 숫자를 만들어 주세요.
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<3; i++)
            {
                for(int j =0; j<3; j++)
                {
                    for(int k =0; k<3; k++)
                    {
                        if(i != j && i!= k && j!= k)
                        {
                            Console.WriteLine($"{i + 1} {j + 1} {k + 1}");
                        }
                    }
                }
            }
        }
    }
}
