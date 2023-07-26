using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileReaderWiter_Binary
{
    internal class Program
    {
        static void Run(string path, byte[] picture)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(picture);
                bw.Flush();

            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\pic1.png";
            byte[] picture;
            using(FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(fs);
                picture = br.ReadBytes((int)fs.Length);
                br.Close();
                
            }

            path = "C:\\Temp\\pic2.png";
            
            Thread t1 = new Thread(()=>Run(path, picture));
            t1.Start();
            t1.IsBackground = true; // Main이 종료되면 같이 종료
                                    // Join -> Main 스레드가 기다려 주는 것

        }
    }
}
