using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAPP007
{
    class Car
    {
        public virtual void Run() //virtual : 밑에서 재 정의 해야하는 함수들
        {
            Console.WriteLine("차가 달린다.");
        }
    }
    class SuperCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("슈퍼카가 달린다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            SuperCar supercar = new SuperCar(); 
            supercar.Run();
        }
    }
}
