using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger { } // 방법 1
    class FileLogger : ILogger  // 방법 2
    {
        private StreamWriter writer;
        // 생성자
        public FileLogger(string path)
        {
            writer = File.CreateText(path); // file class에 file을 만들어 주는 method 
            writer.AutoFlush = true;
        }


        public void WriteLog(string message)
        {
            writer.WriteLine(DateTime.Now.ToShortTimeString() + " " + message);
        }
    } 
    class ClimateMonitor
    {
        private ILogger logger;   // IS-A  : 상속 관계 // HAS-A  : 포함 시키는 관계
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            //핵심 method
            while (true)
            {
                Console.Write("온도를 입력해 주세요. : ");
                string temperature = Console.ReadLine();

                if(temperature == "")
                {
                    break;
                }
                logger.WriteLog("현재온도: " + temperature);
            }
        }
    } // 대상
    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체가 CosoleLog 또는 FileLog 중 1개를 선택 해서 Log 만들기.
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();
        }
    }
}
