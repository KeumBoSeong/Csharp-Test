using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;   
using System.Timers;

namespace TimerApp
{
    internal class Program
    {
        // ﻿5초마다 30초가 되면 종료 
        // 현재 시간과 출력 메시지를 적는 SWBot을 만드세요.!!
                                
        static void Main(string[] args)
        {
            string path = "mylog.txt";
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString()} : 정상작동중");
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Append)))
                {
                    sw.WriteLine($"{System.DateTime.Now.ToString()} : 정상작동중");
                }
                Thread.Sleep(5000);
            }
        }
    }
}
