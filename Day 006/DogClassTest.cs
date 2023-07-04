
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogClassTest
{
    class Dog
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
        public string Eat()
        {
            return "먹습니다.";
        }
        public string Play()
        {
            return "뛰어놉니다.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog tom = new Dog("톰");
            Console.WriteLine($"{tom.Name} 이 음식을 {tom.Eat()}");
            Console.WriteLine($"{tom.Name} 이  {tom.Play()}");
        }
    }
}
