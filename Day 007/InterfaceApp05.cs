using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp04
{
    interface ILogger
    {
       void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger
    {
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
