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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal;
        int pogingenOver = 3;
        public MainWindow()
        {
            InitializeComponent();
            // genereer random getal tussen 1 en 5
            Random rnd = new Random();
            getal = rnd.Next(1, 6);
        }

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            
                pogingenOver--;
                int gok = Convert.ToInt32(txtGok.Text);
                if (gok == getal)
                {
                    lblBericht.Content = "Gewonnen!";
                    btnControle.IsEnabled = false;
                }
                else
                {
                    lblBericht.Content = $"Fout! Je hebt nog {pogingenOver} pogingen over";
                    if (pogingenOver == 0)
                    {
                        btnControle.IsEnabled = false;

                    }
            }
        }
    }
}
