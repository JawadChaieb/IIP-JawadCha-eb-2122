using System.Windows;

namespace WpfFormChecking
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

        private void btnRegistreren_Click(object sender, RoutedEventArgs e)
        {
            // aantal fouten
            int aantalFouten = 0;
            // wis foutmeldingen
            /// lblMessageName.Content = "";
            // check formulier
            if (txtNaam.Text == "")
            {
                lblMessageNaam.Content = "naam moet ingevuld zijn";
                lblMessageNaam.Foreground = Brushes.red;
                aantalFouten++;

            }
            if (txtEmail.Text == "")
            {
                lblEmail.Content = "email moet ingevuld zijn";
                aantalFouten++;

            }
            if (datePicker.SelectedDate == null)
            {
                lblDate.Content = "selecteer een datum";
                aantalFouten++;

            }
            if (cmbProfiel.SelectedItem == null)
            {
                lblProfiel.Content = "een profiel moet geselecteerd worden";
                aantalFouten++;

            }
            if (pwd.Password.ToString() == "")
            {
                lblPaswoord.Content = "een paswoord moet ingevuld worden";
                aantalFouten++;

            }
            if (radioMan.IsChecked == false && radioVrouw.IsChecked == false)
            {
                lblGeslacht.Content = "een geslacht moet geselecteerd worden";
                aantalFouten++;

            }
            if (checkProgrammeren.IsChecked == false && checkNetwerken.IsChecked == false && checkBusiness.IsChecked == false)
            {
                lblInteresses.Content = "naam moet ingevuld zijn";
                aantalFouten++;

            }

            lblstatus.Content = $"Dit formulier bevat {aantalFouten} fouten";

            if (txtEmail.Text != "" && txtEmail.Text != "" && datePicker.SelectedDate != null && 
                cmbProfiel.SelectedItem != null && pwd.Password.ToString() != "" && 
                (radioMan.IsChecked != false || radioVrouw.IsChecked != false))
            {
                lblstatus.Content = "succesvol geregistreerd";

            }


        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.Text = "";
            datePicker.SelectedDate = null;
            cmbProfiel.SelectedItem = null;
            pwd.Password = null;
            radioMan.IsChecked = null;
            radioVrouw.IsChecked = null;
        }

    }
}


