using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtextCopyTest
{
    //A.txt 파일을 만들고 B.txt파일로 복사하세요. 
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\A.text";
            string path2 = "C:\\Temp\\B.text";
            using (Stream st = new FileStream(path, FileMode.Create))
            {
                using(StreamWriter sw = new StreamWriter(st))
                {
                    sw.WriteLine("abcde");
                }
                File.Copy(path, path2);
            }
            
        }
    }
}
