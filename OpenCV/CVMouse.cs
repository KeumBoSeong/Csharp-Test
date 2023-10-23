using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVKeyboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Mat image = new Mat(200, 300, MatType.CV_8U, new Scalar(255)))
            {
                MouseCallback cvMouseCallback = new MouseCallback(Event);
                Cv2.NamedWindow("마우스 이벤트", WindowFlags.AutoSize);
                Cv2.ImShow("마우스 이벤트", image);
                Cv2.SetMouseCallback("마우스 이벤트", cvMouseCallback, image.CvPtr);


                while (true)
                {
                    int key = Cv2.WaitKeyEx(200);

                    if (key == 27)  // 'ESC' Key
                        break;
                }
            }
        }
        static void Event(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userdata)
        {
            Mat data = new Mat(userdata);

            if (@event == MouseEventTypes.LButtonDown)
            {
                Console.WriteLine("마우스 왼쪽 버튼을 누를 때 ");
            }

            else if (@event == MouseEventTypes.RButtonDown)
            {
                Console.WriteLine("마우스 오른쪽 버튼을 누를 때 ");
            }

            else if (@event == MouseEventTypes.RButtonUp)
            {
                Console.WriteLine("마우스 오른쪽 버튼을 땔 때 ");
            }

            else if (@event == MouseEventTypes.LButtonDoubleClick)
            {
                Console.WriteLine("마우스 왼쪽 버튼 더블클릭 ");
            }
        }
    }
}
