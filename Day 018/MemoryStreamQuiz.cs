using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStreamQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\abc.txt";
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            string txt = sr.ReadToEnd();
            // sr.Close(); -> Dispose와 기능은 동일함.
            sr.Dispose();


            Console.WriteLine(txt);

            //////////////////////////////////////////////////
            /// MemoryStream에 저장하는 방식
            MemoryStream ms = new MemoryStream();
            byte[] strBytes = Encoding.UTF8.GetBytes(txt);
            ms.Write(strBytes, 0, strBytes.Length);

            ms.Position = 0;
            StreamReader sr2 = new StreamReader(ms, Encoding.UTF8, true);
            string txt2 = sr2.ReadToEnd();
            Console.WriteLine(txt2);


        }
    }
}
