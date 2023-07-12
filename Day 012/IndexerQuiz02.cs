using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerQuiz02
{
    class ArrayWrapper
    {
        private int[] arr;
        
        public ArrayWrapper(int length)
        {
            arr = new int[length];
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public void Print()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayWrapper arraywrapper = new ArrayWrapper(5);
            for(int i = 0; i < 5; i++)
            {
                arraywrapper[i] = i * 10;

            }
            arraywrapper.Print();
        }
    }
}
