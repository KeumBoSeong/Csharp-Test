using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp003
{
    class Cat
    {
        //이름
        //색깔
        //나이
        //메소드 "야옹"
        public string Name;
        public string Color;
        public int Age;

        // 생성자 Constructor
        public Cat()        // 아무것도 없는 생성자 -> default 생성자
        {
            // 초기값
            this.Name = "야옹이";
            this.Age = 2;
            this.Color = "노란색";

        }
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 객체 생성
            Cat cat = new Cat();
            // 생성 후 초기화
            cat.Name = "키티";
            cat.Color = "흰색";
            cat.Age = 10;

            // 출력
            Console.WriteLine($"이름 : { cat.Name} \n색깔 : { cat.Color} \n나이 : { cat.Age}");
        }
    }
}
