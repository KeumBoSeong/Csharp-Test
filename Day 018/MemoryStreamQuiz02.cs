using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStreamQuiz02
{
    internal class Program
    {
        /*MemoryStream 객체에 1, 2, 3, 4, 5 정수값을 쓰고
        이를 MemoryStream 객체에서 읽어서 콘솔 화면에 출력해 주세요.
        -----------------------------------------------------------
        [출력화면]
        1 2 3 4 5*/
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            byte[] arrBytes = new byte[] {1, 2, 3, 4, 5};
            ms.Write(arrBytes, 0, arrBytes.Length);

            ms.Position = 0; // Position을 0으로 돌려야함.
            byte[] buffer = new byte[5];
            ms.Read(buffer, 0, 5);

            foreach (byte b in buffer)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();
        }
    }
}
