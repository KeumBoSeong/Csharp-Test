using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiltChannelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat image = new Mat("C:\\Temp\\img\\lenna.jpg", ImreadModes.Color);

            if (image.Empty())
            {
                throw new Exception("이미지를 찾을 수 없거나 읽을 수 없습니다.");
            }

            Mat[] bgr = Cv2.Split(image);

            new Window("image", image);
            new Window("B", bgr[0]);
            new Window("G", bgr[1]);
            new Window("R", bgr[2]);

            Cv2.WaitKey();


        }
    }
}
