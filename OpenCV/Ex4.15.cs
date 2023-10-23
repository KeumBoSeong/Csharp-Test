using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            Cv2.NamedWindow("palette");
            Cv2.CreateTrackbar("color", "palette", ref value, 255);

            while (true)
            {
                int pixel = Cv2.GetTrackbarPos("color", "palette");
                Mat src = new Mat(new Size(500, 500), MatType.CV_8UC3, new Scalar(pixel, value, value));

                Cv2.ImShow("palette", src);
                if (Cv2.WaitKey(33) == 'q')
                    break;
            }
            Cv2.DestroyAllWindows();
        }
    }
}
