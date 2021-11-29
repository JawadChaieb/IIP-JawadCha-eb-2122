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

namespace WpfPizza
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

        private void pizza1_Checked(object sender, RoutedEventArgs e)
        {
            txtIngredienten.Text = "Tomatensaus, mozzarella & oregano";
            imgControl.Source = new BitmapImage(new Uri("Images/pizza1.jpg", UriKind.Relative)) ;
        }

        private void pizza2_Checked(object sender, RoutedEventArgs e)
        {
            txtIngredienten.Text = "Tomatensaus, mozzarella, rode ui, kip, paprika, pepperoni & spaanse pepers";
        }

        private void pizza3_Checked(object sender, RoutedEventArgs e)
        {
            txtIngredienten.Text = "Tomatensaus, ananas";
        }

    }
}
