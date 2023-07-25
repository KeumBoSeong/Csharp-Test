using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SerializationApp
{
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "a.json";
            using (Stream ws = new FileStream(path, FileMode.Create))
            {
                NameCard nc = new NameCard();
                nc.Name = "홍길동";
                nc.Phone = "010-1111-1111";
                nc.Age = 20;

                // system.json package 설치해야함
                // 객체 직렬화
                string jsonString = JsonSerializer.Serialize<NameCard>(nc);
                //Console.WriteLine(jsonString);

                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes, 0, jsonBytes.Length);
                // a.json File 만들기 및 객체 직렬화 후 File에 넣기
            }
            // 파일에서 객체 꺼내기 그리고 콘솔에 출력
            using (Stream rs = new FileStream(path, FileMode.Open))
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonString = Encoding.UTF8.GetString(jsonBytes);

                NameCard nc2 = JsonSerializer.Deserialize<NameCard>(jsonString);

                Console.WriteLine(nc2.Name);
                Console.WriteLine(nc2.Phone);
                Console.WriteLine(nc2.Age);
            }

        }
    }
}
