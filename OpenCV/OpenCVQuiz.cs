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

namespace OpenCVQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = "C:\\Temp\\img\\image_ready.jpg";

            using (Mat colorImage = new Mat(imagePath, ImreadModes.Color))
            {
                Bitmap bitmap = MatToBitmap(colorImage);
                pictureBox1.Image = bitmap;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string imagePath = "C:\\Temp\\img\\Test.png";

            using (Mat colorImage = new Mat(imagePath, ImreadModes.Color))
            {
                Mat gray = new Mat();

                // 흑백 화면으로 변경 함수
                Cv2.CvtColor(colorImage, gray, ColorConversionCodes.BGR2GRAY);

                Bitmap bitmap = MatToBitmap(gray);
                pictureBox1.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imagePath = "C:\\Temp\\img\\Test.png";

            using (Mat colorImage = new Mat(imagePath, ImreadModes.Color))
            {
                Bitmap bitmap = MatToBitmap(colorImage);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Mat img = Cv2.ImRead("C:\\Temp\\img\\Test.png");
            bool save;

            ImageEncodingParam[] prms = new ImageEncodingParam[]
            {
                new ImageEncodingParam(ImwriteFlags.JpegQuality, 100),
                new ImageEncodingParam(ImwriteFlags.JpegProgressive,1)
            };

            save = Cv2.ImWrite("save.jpeg", img, prms);
          
        }
    }
}
