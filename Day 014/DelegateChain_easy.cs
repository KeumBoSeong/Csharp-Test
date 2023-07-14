using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain_easy
{
    
    internal class Program
    {
        delegate void ThereisFire(string location);
        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불이났어요. 위치는{location} 이에요.");
        }
        public static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 피하세요.");
        }
        public static void Shoutout(string location)
        {
            Console.WriteLine($"{location}에 불이 났어요.");
        }
        static void Main(string[] args)
        {
            ThereisFire Fire = new ThereisFire(Call119);
            Fire += new ThereisFire(Shoutout);
            Fire += new ThereisFire(Escape);
            

            Fire("우리집");
        }
    }
}
