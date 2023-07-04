using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPApp006
{
    class Car // 부모 class
    {
        public string name;
        protected int speed;
        private string brand;
        public void Run()
        {
            Console.WriteLine("차가 달리다");
        }
    }
    class SuperCar : Car //상속 //자식 class
    {
        public SuperCar()
        {
            this.speed = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SuperCar sc = new SuperCar();
            sc.Run();
            sc.name = "자동차";
        }
    }
}
