using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P._75_Practice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("서울특별시");
            comboBox1.Items.Add("인천광역시");
            comboBox1.Items.Add("울산광역시");
            comboBox1.Items.Add("대전광역시");
            comboBox1.Items.Add("대구광역시");
            comboBox1.Items.Add("광주광역시");
            comboBox1.Items.Add("부산광역시");


            listBox1.Items.Add("10대");
            listBox1.Items.Add("20대");
            listBox1.Items.Add("30대");
            listBox1.Items.Add("40대");
            listBox1.Items.Add("50대");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str;
            Str = textBox1.Text + "님은";
            if (radioButton1.Checked == true)
            {
                Str = Str + radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                Str = Str + radioButton2.Text;
            }

            Str = Str + "이고" + "\r\n" + "연령은" + listBox1.Text + "이고" + "\r\n" + "거주지는" + comboBox1.Text + "이고" + "\r\n" + "좋아하는 동물은" + Environment.NewLine;

            if (checkBox1.Checked == true)
            {
                Str = Str + checkBox1.Text + "\r\n";
            }
            if (checkBox2.Checked == true)
            {
                Str = Str + checkBox2.Text + "\r\n";
            }
            if (checkBox3.Checked == true)
            {
                Str = Str + checkBox3.Text + "\r\n";
            }
            if (checkBox4.Checked == true)
            {
                Str = Str + checkBox4.Text + "\r\n";
            }
            if (checkBox5.Checked == true)
            {
                Str = Str + checkBox5.Text + "\r\n";
            }
            if (checkBox6.Checked == true)
            {
                Str = Str + checkBox6.Text + "\r\n";
            }
            if (checkBox7.Checked == true)
            {
                Str = Str + checkBox7.Text + "\r\n";
            }
            if (checkBox8.Checked == true)
            {
                Str = Str + checkBox8.Text + "\r\n";
            }
            if (checkBox9.Checked == true)
            {
                Str = Str + checkBox9.Text + "\r\n";
            }

            textBox2.Text = Str + "입니다.";
        }
    }
}
