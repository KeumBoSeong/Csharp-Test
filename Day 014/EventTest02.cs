using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest02
{
    delegate void Mydelegate(int a);

    class Market
    {
        public event Mydelegate CustomerEvent;

        public void BuySomething(int CustomerNo)
        {
            if (CustomerNo == 30)
            {
                CustomerEvent(CustomerNo);
            }
        }
    }
    internal class Program
    {
        static public void MyHandler(int value)
        {
            Console.WriteLine($"축하합니다 ! {value}번 째 고객 이벤트에 당첨되셨습니다.");
        }
        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new Mydelegate(MyHandler);

            for(int customerNo =0; customerNo < 100; customerNo += 10)
            {
                market.BuySomething(customerNo);
            }
        }
    }
}
