using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.ComponentModel;

namespace WpfStartApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btnHello = new Button();
            btnHello.Content = "Say Good By";
            btnHello.Width = 200;
            btnHello.Height = 50;
            btnHello.FontSize = 26;
            btnHello.Click += Button_Click;
            btnHello.Background = (Brush)TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("White");

            grid.Children.Add(btnHello);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + txtHello.Text);
        }
    }
}
