using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSize
{
    class MainApp : Form
    {
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender; // sender 를 form 으로 Down Casting.
            int oldWidth = form.Width;
            int oldHeight = form.Height;

            if(e.Button == MouseButtons.Right)
            {
                if(oldHeight < oldWidth)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;

                }
                Console.WriteLine("오른쪽 마우스 버튼이 클릭되었습니다.");
            }
            else if (e.Button == MouseButtons.Left)
            {
                if(oldWidth < oldHeight)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
                Console.WriteLine("왼쪽 마우스 버튼이 클릭되었습니다.");
            }
        }
        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            form.Width = 600;
            form.Height = 400;

            // Mouse Event 처리
            // 1. 왼쪽 마우스 클릭
            form.MouseClick += form_MouseDown; 
            // 2. 오른쪽 마우스 클릭

            Application.Run(form);
        }
    }
}
