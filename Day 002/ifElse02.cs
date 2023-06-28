using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            if (n>=90)
            
                Console.WriteLine("A");
            
            else if (n>=80)
            
                Console.WriteLine("B");
            
            else if (n>=70)

                Console.WriteLine("C");
            
            else if (n>=60)
            
                Console.WriteLine("D");
            
            else
            
                Console.WriteLine("F");
     
        }   
    }
}
