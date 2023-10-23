using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mat image1 = new Mat(250, 250, MatType.CV_8UC1, Scalar.All(0));
            Mat image2 = new Mat(250, 250, MatType.CV_8UC1, Scalar.All(0));

            OpenCvSharp.Point center = new OpenCvSharp.Point();
            Cv2.Circle(image1, center, 80, Scalar.All(255), -1);
            Cv2.Rectangle(image2, new OpenCvSharp.Point(0, 0), new OpenCvSharp.Point(125, 250), Scalar.All(255), -1);

            //Bitmap bitmap = BitmapConverter.ToBitmap(image1);
            //pictureBox2.Image = bitmap;
            //using (Mat image1 = new Mat(500, 500, MatType.CV_8UC1, Scalar.All(0)))
            //{
            //    OpenCvSharp.Point center = new OpenCvSharp.Point(image1.Width / 2, image1.Height / 2);
            //    Cv2.Circle(image1, center, 100, Scalar.All(255), -1);
            //    Bitmap bitmap = BitmapConverter.ToBitmap(image1);
            //    pictureBox2.Image = bitmap;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Mat image1 = new Mat(500, 500, MatType.CV_8UC1, Scalar.All(0)))
            {
                OpenCvSharp.Point center = new OpenCvSharp.Point(image1.Width / 2, image1.Height / 2);
                Cv2.Circle(image1, center, 100, Scalar.All(255), -1);
                Bitmap bitmap = BitmapConverter.ToBitmap(image1);
                pictureBox2.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Mat image2 = new Mat(500, 500, MatType.CV_8UC1, Scalar.All(0)))
            {
                OpenCvSharp.Point center = new OpenCvSharp.Point(image2.Width / 2, image2.Height / 2);
                Cv2.Rectangle(image2, new OpenCvSharp.Point(0, 0), new OpenCvSharp.Point(250, 500), Scalar.All(255), -1);
                Bitmap bitmap = BitmapConverter.ToBitmap(image2);
                pictureBox2.Image = bitmap;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mat image1 = new Mat(500, 500, MatType.CV_8UC1, Scalar.All(0));
            Mat image2 = new Mat(500, 500, MatType.CV_8UC1, Scalar.All(0));
            Mat image3 = new Mat();

            OpenCvSharp.Point center = new OpenCvSharp.Point();
            Cv2.Circle(image1, center, 80, Scalar.All(255), -1);
            Cv2.Rectangle(image2, new OpenCvSharp.Point(0, 0), new OpenCvSharp.Point(250, 500), Scalar.All(255), -1);

            Cv2.BitwiseAnd(image1, image2, image3);
            Bitmap bitmap = BitmapConverter.ToBitmap(image3);
            pictureBox2.Image = bitmap;     
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
