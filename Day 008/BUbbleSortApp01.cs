using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUbbleSortApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 7, 5, 2, 3, 9, 1, 4, 8, 6, 11 };
            //Array.Sort(list);
            int temp;

            for(int i= list.Length-1; i>0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
