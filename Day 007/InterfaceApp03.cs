using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface03
{
    interface ILooger
    {
        void WriteLog(string message);
    }
    class ConsoleLooger : ILooger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILooger logger = new ConsoleLooger();
            logger.WriteLog("Hellow, World");
        }
    }
}
