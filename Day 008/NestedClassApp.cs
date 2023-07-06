using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassApp
{   // 외부 Class, 내부 Class
    class OuterClass
    {
        private int OuterNumber;

        class InnerClass
        {
            public void DoSomething()
            {
                OuterClass outer = new OuterClass();
                outer.OuterNumber = 100;
            }

            
        }
        static void Main(string[] args)
        {
        }
    }
}
