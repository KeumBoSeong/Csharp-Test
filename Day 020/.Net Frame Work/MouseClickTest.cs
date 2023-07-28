using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClickTest
{
    //[C#] 마우스 버튼 클릭 후 정보를 출력하세요.
    //﻿마우스 현재 좌표와 어떤 버튼을 클릭 했는지 작성해 보세요.
    class Program : Form
    {
        static void Click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Console.WriteLine("X 좌표 :" + e.X);
                Console.WriteLine("Y 좌표 :" + e.Y);
                Console.WriteLine("왼쪽 마우스 버튼을 클릭 하셨습니다.");
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                Console.WriteLine("X 좌표 :" + e.X);
                Console.WriteLine("Y 좌표 :" + e.Y);
                Console.WriteLine("오른쪽 마우스 버튼을 클릭 하셨습니다. ");
            }
            else if(e.Button == MouseButtons.Middle)
            {
                Console.WriteLine("X 좌표 :" + e.X);
                Console.WriteLine("Y 좌표 :" + e.Y);
                Console.WriteLine("가운데 마우스 버튼을 클릭 하셨습니다.");
            }
        }
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Width = 640;
            form.Height = 480;

            form.MouseDown += new MouseEventHandler(Click); 

            Application.Run(form);  
        }
    }
}
