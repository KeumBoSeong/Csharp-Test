using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


// 고양이 클래스를 생성
// 생성자는 default 생성자로 만듦
// 단, 멤버는
// private string name;
// private int age;
// private color

//간접접근 Getter / Setter 만들기
//setName(), getName()
//setAge(), getAge()
//setColor(), getColor()
//----------------------------------------
//네로
//10살
//검은색
namespace CatClassTest01
{
    class Cat
    {
        private string Name;
        private int Age;
        public string Color;

        public void setName(string _Name)
        {
            Name = _Name;
        }
        public void setColor(string _Color)
        {
            Color = _Color;
        }
        public void setAge(int _Age)
        {
            Age = _Age;
        }
        public string getName()
        {
            return Name;
        }
        public string getColor()
        {
            return Color;
        }
        public int getAge()
        {
            return Age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat nero = new Cat();
            nero.setName("네로");
            nero.setColor("검은색");
            nero.setAge(10);

            Console.WriteLine($"이름:{nero.getName()} 색깔:{nero.getColor()} 나이:{nero.getAge()}");
        }
    }
}
