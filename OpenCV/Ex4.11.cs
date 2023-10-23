using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat one = new Mat("C:\\Temp\\img\\1234\\one.jpg");
            Mat two = new Mat("C:\\Temp\\img\\1234\\two.jpg");
            Mat three = new Mat("C:\\Temp\\img\\1234\\three.jpg");  
            Mat four = new Mat("C:\\Temp\\img\\1234\\four.jpg");

            Mat left = new Mat();
            Mat right = new Mat();
            Mat dst = new Mat();

            Cv2.VConcat(new Mat[] { one, three }, left);
            Cv2.VConcat(new Mat[] { two, four }, right);
            Cv2.HConcat(new Mat[] { left, right }, dst);

            Cv2.ImShow("dst", dst);
            Cv2.WaitKey();
            Cv2.DestroyAllWindows();
        }
    }
}
