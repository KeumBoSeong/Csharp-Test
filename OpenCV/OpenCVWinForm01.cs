using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCVWinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "OpenCV 버전 : " + Cv2.GetVersionString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = "lenna.jpg";

            using (Mat colorImage = new Mat(imagePath, ImreadModes.Color))
            {
                Mat gray = new Mat();

                // 흑백 화면으로 변경 함수
                Cv2.CvtColor(colorImage, gray, ColorConversionCodes.BGR2GRAY);

                Bitmap bitmap = MatToBitmap(gray);
                pictureBox1.Image = bitmap;
            }
        }

        private Bitmap MatToBitmap(Mat image)
        {
            using (var stream = new MemoryStream())
            {
                image.WriteToStream(stream);

                return new Bitmap(stream);
            }
        }
    }
}
