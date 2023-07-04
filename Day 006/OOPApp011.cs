using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp011
{
    abstract class Emotion
    {
        public abstract string Feel();
    }
    class Love : Emotion
    {
        public override string Feel()
        {
            return "감정";
        }
    }
    class Angry : Love
    {

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Angry angry = new Angry();
            Console.WriteLine(angry.Feel());
        }
    }
}
