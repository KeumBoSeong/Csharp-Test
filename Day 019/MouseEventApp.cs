using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEventApp
{
    internal class MainApp : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender + { ((Form)sender).Text}");
            Console.WriteLine($"X:{e.X}Y:{e.Y}");
            Console.WriteLine($"Button : {e.Button} Clicks : {e.Clicks}");
            Console.WriteLine();
        }
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        static void Main(string[] args)
        {
            MainApp app = new MainApp("Mouse Event Test");
            Application.Run(app);
        }
    }
}
