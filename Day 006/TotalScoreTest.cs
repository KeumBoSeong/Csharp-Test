using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalScoreTest
{
    class Calculator
    {
        public int score(int kor, int eng, int math)
        {
            return kor + eng + math;
        
        }
        public double average(double kor, double eng, double math)
        {
            return (kor + eng + math) / 3;
        }

    }
    

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator total = new Calculator();
            
            Calculator avg = new Calculator();
            Console.WriteLine($"점수를 입력하세요:");
            Console.Write($"국어 :");
            int kor = int.Parse(Console.ReadLine());
            Console.Write($"영어 :");
            int eng = int.Parse(Console.ReadLine());
            Console.Write($"수학 :");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("총점 : " + total.score(kor, math, eng));
            Console.WriteLine("평균 : " + total.average(kor, math, eng));



        }
    }
}
