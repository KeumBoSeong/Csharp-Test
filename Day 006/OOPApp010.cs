using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp010
{
    abstract class Shape
    {
        public abstract void Draw(); // 추상 메소드는 구현하지 않음
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            //throw new NotImplementedException();
            Console.WriteLine("삼각형을 그리다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.Draw();

            Shape s = new Triangle();
            s.Draw();
        }
    }
}
