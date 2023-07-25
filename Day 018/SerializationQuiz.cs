using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializationQuiz
{
    /* student.json 파일로 객체를 직렬화 한 후 
    파일의 내용을 읽어와 객체를 다시 역직렬화하여 값을 출력하세요.
    ------------------------------------
    학번 : 12345
    이름 : 이순신
    전공 : 스마트팩토리*/
    class Student
    {
        public int STID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Student.json";
            using (Stream ws = new FileStream(path, FileMode.Create))
            {
                Student std = new Student();
                std.STID = 12345;
                std.Name = "이순신";
                std.Major = "스마트팩토리";

                string jsonString = JsonSerializer.Serialize<Student>(std);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes, 0, jsonBytes.Length);
                
            }
            using(Stream rs = new  FileStream(path, FileMode.Open))
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonString = Encoding.UTF8.GetString(jsonBytes);

                Student std2 = JsonSerializer.Deserialize<Student>(jsonString);
                Console.WriteLine("학번:" + std2.STID);
                Console.WriteLine("이름:" + std2.Name);
                Console.WriteLine("전공:" + std2.Major);
            }

        }
    }
}
