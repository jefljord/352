using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Paint
{
    class HelloFromMain
    {
        [STAThread]
        public static void Main()
        {
            Paint.App app = new Paint.App();
            app.InitializeComponent();
            
            MessageBoxResult hello = MessageBox.Show("Hello From Main");

            app.Run();
        }
    }
}
