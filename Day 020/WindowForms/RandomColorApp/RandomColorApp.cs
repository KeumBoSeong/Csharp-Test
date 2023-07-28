using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Random rand;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            MouseClick += RandomClorfunction; ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
        }

        private void RandomClorfunction(object sender, MouseEventArgs e)
        {
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }


    }
}
