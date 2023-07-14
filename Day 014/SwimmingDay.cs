using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingDay
{
    class Swimming
    {
        public void Day(int i)
        {
            if (i == 1 || i == 3 || i == 5)
                Console.WriteLine("enjoy");
            else
                Console.WriteLine("opps");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Swimming swimming = new Swimming();
            int i = int.Parse(Console.ReadLine());
            swimming.Day(i);   
         
        }
    }
}
