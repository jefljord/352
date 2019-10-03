using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Inkcanvas.Strokes.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(200, 54, 150);
           
        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {

            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(200, 54, 150);

        }

        private void Size_Click(object sender, RoutedEventArgs e)
        {
            Inkcanvas.DefaultDrawingAttributes.Width = 5;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 0);
            Inkcanvas.DefaultDrawingAttributes.Width = 2;
        }
    }
    
}
