using System.IO;

namespace FileApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 임베디드 프로그래밍 50% -> 1/0 입출력
            // 리눅스 모든것이 File -> Low level - > byte[]
            // File과 FileInfo 
            FileStream fs = File.Create("a.dat"); // 생성
            FileInfo file = new FileInfo("a.dat");
            FileStream fs2 = file.Create();

            File.Copy("a.dat", "b.dat");
            FileInfo src = new FileInfo("a.dat");
            FileInfo dst = src.CopyTo("b.dat");

            File.Delete("a.dat");
            FileInfo file2 = new FileInfo("a.dat");
            file.Delete();

            File.Move("a.dat", "b.dat");
            FileInfo file3s = new FileInfo("a.dat");
            file.MoveTo("b.dat");

        }
    }
}
