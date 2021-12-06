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

namespace WpfSliderKleur
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblWaarde.Content = Math.Round(slr.Value);
            if (Math.Round(slr.Value) <= 25)
            {
                lblWaarde.Foreground = Brushes.Green;
            }
            else if (Math.Round(slr.Value) > 25 && Math.Round(slr.Value) <= 50)
            {
                lblWaarde.Foreground = Brushes.Yellow;
            }
            else if (Math.Round(slr.Value) > 50 && Math.Round(slr.Value) <= 75)
            {
                lblWaarde.Foreground = Brushes.Orange;
            }
            else {
                lblWaarde.Foreground = Brushes.Red;
                    }



        }
    }
}
