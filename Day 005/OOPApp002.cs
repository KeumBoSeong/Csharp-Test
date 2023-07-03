using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp002
{
    class Dog
    {
        public string Name;
        public int Age;
        public string Color;
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog nero = new Dog();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Bark();
            Console.WriteLine(nero.Name + " " + nero.Color);
        }
    }
}
