using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat src = new Mat(new Size(500,500), MatType.CV_8UC3, new Scalar(255, 255, 255));

            Cv2.ImShow("draw", src);
            // 마우스 이벤트 callback 객체 생성
            MouseCallback cvmouseCallback = new MouseCallback(Event);

            //부착 or 등록
            Cv2.SetMouseCallback("draw", cvmouseCallback,src.CvPtr);

            Cv2.WaitKey();
            Cv2.DestroyAllWindows();
        }
        static void Event(MouseEventTypes @enent, int x, int y, 
                          MouseEventFlags flags, IntPtr userdata)
        {
            Mat data = new Mat(userdata);

            if(flags == MouseEventFlags.LButton)
            {
                Cv2.Circle(data, new Point(x, y), 10, new Scalar(0, 0, 255), -1);
                Cv2.ImShow("draw", data);
            }
        }
    }
}
