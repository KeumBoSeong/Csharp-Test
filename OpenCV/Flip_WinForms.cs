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

namespace Flip_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "C:\\Temp\\img\\flip.jpg";
            using (Mat image = new Mat(path, ImreadModes.Color))

            {
                Bitmap bitmap = BitmapConverter.ToBitmap(image);
                pictureBox1.Image = bitmap;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Temp\\img\\flip.jpg";
            using (Mat image = new Mat(path, ImreadModes.Color))

            {
                Bitmap bitmap = BitmapConverter.ToBitmap(image);
                pictureBox2.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string image = "C:\\Temp\\img\\flip.jpg";
            using (Mat i = new Mat(image, ImreadModes.Color))
            {
                Mat x_axis = new Mat();
                Cv2.Flip(i, x_axis, FlipMode.X);
                Bitmap bitmap = BitmapConverter.ToBitmap(x_axis);

                pictureBox2.Image = bitmap;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string image = "C:\\Temp\\img\\flip.jpg";
            using (Mat i = new Mat(image, ImreadModes.Color))
            {
                Mat y_axis = new Mat();
                Cv2.Flip(i, y_axis, FlipMode.Y);
                Bitmap bitmap = BitmapConverter.ToBitmap(y_axis);

                pictureBox2.Image = bitmap;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string image = "C:\\Temp\\img\\flip.jpg";
            using (Mat i = new Mat(image, ImreadModes.Color))
            {
                Mat xy_axis = new Mat();
                Cv2.Flip(i, xy_axis, FlipMode.XY);
                Bitmap bitmap = BitmapConverter.ToBitmap(xy_axis);

                pictureBox2.Image = bitmap;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string image = "C:\\Temp\\img\\flip.jpg";
            using (Mat i = new Mat(image, ImreadModes.Color))
            {
                Mat rep_img = new Mat();
                Cv2.Repeat(i, 1,2, rep_img);
                Bitmap bitmap = BitmapConverter.ToBitmap(rep_img);

                pictureBox2.Image = bitmap;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string image = "C:\\Temp\\img\\flip.jpg";
            using (Mat i = new Mat(image, ImreadModes.Color))
            {
                Mat trans_img = new Mat();
                Cv2.Transpose(i, trans_img);
                Bitmap bitmap = BitmapConverter.ToBitmap(trans_img);

                pictureBox2.Image = bitmap;
            }
        }
    }
}
