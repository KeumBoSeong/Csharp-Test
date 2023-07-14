using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventestApp01
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if(temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(string.Format($"{number} : 짝"));
            }
        }
    }
    
    internal class Program
    {
        static public void MyHandler(string mesaage)
        {
            Console.WriteLine(mesaage); 
        }
        
       
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for(int i = 0; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
