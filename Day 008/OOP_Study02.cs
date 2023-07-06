using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Study02
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape 생성자가 호출됨");
        }
        public virtual void Draw()
        {
            Console.WriteLine("그리다.");
        }
        public virtual void Draw(string pen)
        {
            Console.WriteLine(pen + "그리다.");
        } 
        public virtual int Draw(string pen, int v)
        {
            Console.WriteLine(pen + "그리다." + "굵기는" + v);
            return v;
        }// overloading <같은 이름에 여러가지 함수를 사용 할 수 있음>
    }
    class Triangle : Shape
    {
        public Triangle()
        {
            Console.WriteLine("Triangle 생성자가 호출됨.");
        }
        // overriding (재정의)
        public override void Draw()
        {
            base.Draw();
        }

        public override void Draw(string pen)
        {
            base.Draw(pen);
        }

        public override int Draw(string pen, int v)
        {
            return base.Draw(pen, v);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t=new Triangle();
        }
    }
}
