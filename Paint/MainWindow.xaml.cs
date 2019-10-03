using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
/*
 * Author: Jeffrey Jordan
 * Date: 10/3/19
 * File: MainWindow.xaml.cs
 * Description: The primary file for holding framework and application code.
 */


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
            InitializeComponent(); // initializes the window thread
        }

        private void Clear_Click(object sender, RoutedEventArgs e) // button click method
        {
            Inkcanvas.Strokes.Clear(); // clears the window
        }

        private void Button_Click(object sender, RoutedEventArgs e) // button click method
        {

            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(200, 54, 150); // changes color of the pen
           
        }

        private void Color_Click(object sender, RoutedEventArgs e) // button click method
        {

            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(200, 54, 150); // repeat function was left alone to not mess up build

        }

        private void Size_Click(object sender, RoutedEventArgs e) // button click method
        {
            Inkcanvas.DefaultDrawingAttributes.Width = 5; // changes size of the pen
        }

        private void Reset_Click(object sender, RoutedEventArgs e) // button click method
        {
            Inkcanvas.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 0); // resets the settings of the pen to default.
            Inkcanvas.DefaultDrawingAttributes.Width = 2;
        }
    }
    
}
