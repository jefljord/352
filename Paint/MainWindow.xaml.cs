/*
 * Author: Jeffrey Jordan
 * Date: 10/3/2019
 * File: MainWindow.xaml.cs
 * Description: The primary file holding the project's code and framework. 
 */

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
            InitializeComponent();  // begins the thread
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            /* Description:
             * Framework generated method for recognizing button clicks.
             */

            Inkcanvas.Strokes.Clear(); // clears the canvas
        
        }

        private void Button_Click(object sender, RoutedEventArgs e) // button click method
        {

            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(200, 54, 150); // changes the color of the pen
           
        }

        private void Color_Click(object sender, RoutedEventArgs e) // left this method so it wouldn't disrupt the build
        {

            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(200, 54, 150);

        }

        private void Size_Click(object sender, RoutedEventArgs e) // button click method
        {
            Inkcanvas.DefaultDrawingAttributes.Width = 5; // changes size of the pen
        }

        private void Reset_Click(object sender, RoutedEventArgs e) // button click method
        {
            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 0); // changes back to black
            Inkcanvas.DefaultDrawingAttributes.Width = 2; // resets size to default
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // this will change the shade of the color
        {
            absFact g = new randShade();
            int gg = g.shader(); // called 3 times for the rgb values
            int gb = g.shader();
            int gr = g.shader();
            
            byte ggg = Convert.ToByte(gg); // convert from int to bytes
            byte gbb = Convert.ToByte(gb);
            byte grr = Convert.ToByte(gr);
            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(grr, ggg, 20);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            redShade g = new redShade();
            int gg = g.shader(); // called 3 times for the rgb values
            int gb = g.shader();
            int gr = g.shader();

            byte ggg = Convert.ToByte(gg); // convert from int to bytes
            byte gbb = Convert.ToByte(gb);
            byte grr = Convert.ToByte(gr);
            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(255, gbb, grr);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            blueShade g = new blueShade();
            int gg = g.shader(); // called 3 times for the rgb values
            int gb = g.shader();
            int gr = g.shader();

            byte ggg = Convert.ToByte(gg); // convert from int to bytes
            byte gbb = Convert.ToByte(gb);
            byte grr = Convert.ToByte(gr);
            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(ggg, gbb, 255);
        }
    }
    
}
