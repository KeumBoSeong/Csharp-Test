using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam01
{
    //1. Weapon interface
    interface IWeapon
    {
        string Attack();
    }
    //2. IBow interface , method --> Attack()
    interface IBow : IWeapon
    {

    }
    //3. Hero --> member 변수 Name Property
    class Hero
    {
        public string Name { get; set; }
    }
    //4. knight --> 아더 기사를 생성
    class Knight : Hero, IBow
    {
        public Knight(string name)  //인자가 있는 생성자
        {
            Name = name;
        }
        public string Attack()
        {
            return "활을 쏩니다.";
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            Knight arthur = new Knight("아더");
            Console.WriteLine($"{arthur.Name}가 {arthur.Attack()}");
            
            
        }
    }
}
