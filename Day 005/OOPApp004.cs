using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp004
{
    
    class Cat
    {
        //멤버 변수
        public string Name;
        public string Color;
        // default 생성자
        public Cat()
        {
            Name = "";
            Color = "";
        }
        // 인자가 있는 생성자
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            Console.WriteLine(kitty.Name + kitty.Color);

            Cat nero = new Cat("네로", "검은색");
            
        }
    }
}
