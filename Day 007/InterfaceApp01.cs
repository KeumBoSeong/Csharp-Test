using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp01
{
    interface Wing // 특수한 class 를 응용한 것.
    {
        void Fly(); // public 은 사용 할 수 X
    }
    class Horse
    {
       
    }
    class Angel : Wing
    {
        public void Fly()
        {
            Console.WriteLine("천사가 날다.");
        }
    }
    class Unicon : Horse, Wing // C#은 다중 상속을 허용하지 않음. > interface 사용(class처럼)
    {
        public void Fly()
        {
            Console.WriteLine("유니콘이 날다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Angel angel = new Angel();
            angel.Fly();
            Unicon unicon = new Unicon();
            unicon.Fly();
        }
    }
}
