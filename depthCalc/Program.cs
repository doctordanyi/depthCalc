using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.IO;
using System.Windows.Forms;

namespace depthCalc
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
