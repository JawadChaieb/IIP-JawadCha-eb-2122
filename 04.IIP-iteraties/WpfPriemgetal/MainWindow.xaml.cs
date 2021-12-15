using System;
using System.Windows;
using System.Windows.Media;

namespace WpfPriemgetal
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtGetal.Text);
            int deler = getal / 2;
            while (getal % deler != 0 && deler > 1)
            {
                deler--;
            }
            if (deler == 1)
            {
                lblPriem.Foreground = Brushes.Green;
                lblPriem.Content = $"{getal} is een priemgetal";
            }
            else
                lblPriem.Foreground = Brushes.Red;
            lblPriem.Content = $"{getal} is geen priemgetal";

        }
    }
}
