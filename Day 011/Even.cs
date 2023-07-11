using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cnt = 0;
            int cnt2 = 0;
            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    cnt = 0; //꼭 들어가야함
              
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            cnt++;
                        }
                    }
                    if (cnt % 2 == 0)
                    {
                        cnt2++;
                    }

                }
                Console.WriteLine(cnt2);
            }

        }
    }
}
