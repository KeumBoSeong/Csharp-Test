using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp02
{

    //사칙연산을 하나는 계산기 프로그램 작성
    class Calculator
    {
        // 1. 멤버변수
        private string x;
        // 2. 생성자
        // 디폴트 생성자는 만들지 않으면 자동으로 생성된다.
        // 단, 인자가 있는 생성자가 1개라도 있으면 자동으로 생성되지 X
        public Calculator() // 디폴트 생성자
        {

        }
        
        public Calculator(string _x) //인자가 있는 생성자
        {
            x = _x;  // this 생략 가능
        }

        // 3. 멤버 메소드
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal1 = new Calculator(); // new 뒤에 있는 모양 > 생성자 
                                                // 인자가 있는 생성자만 있을 때, 자동으로 생성 X
            Calculator cal2 = new Calculator("홍길동");
        }
    }
}
