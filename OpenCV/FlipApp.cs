using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FlipApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat image = new Mat("C:\\Temp\\img\\flip.jpg", ImreadModes.Color);

            if (image.Empty())
            {
                throw new System.Exception("이미지가 로드되지 않았습니다.");
            }

            Mat x_axis = new Mat();
            Mat y_axis = new Mat();
            Mat xy_axis = new Mat();
            Mat rep_img = new Mat();
            Mat trans_img = new Mat();
    
            Cv2.Flip(image, x_axis, FlipMode.X);
            Cv2.Flip(image, y_axis, FlipMode.Y);
            Cv2.Flip(image, xy_axis, FlipMode.XY);

            Cv2.Repeat(image, 1, 2, rep_img);

            Cv2.Transpose(image, trans_img);


            new Window("image", image);
            new Window("x_axis", x_axis);
            new Window("y_axis", y_axis);
            new Window("xy_axis", xy_axis);
            new Window("rep_img", rep_img);
            new Window("trans_img", trans_img);
            Cv2.WaitKey();
        }
    }
}
