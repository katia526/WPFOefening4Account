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

namespace WPFOefening4Account
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

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            
            Window1 newWindow = new Window1();
            newWindow.Voornaam.Text = txtVoornaam.Text;
            newWindow.Achternaam.Text = txtAchternaam.Text;
            newWindow.Straat.Text = txtStraat.Text;
            newWindow.Woonplaats.Text = txtPlaats.Text;
            newWindow.Leeftijd.Text = txtLeeftijd.Text;
            if (man.IsChecked == true)
            {
                newWindow.Geslacht.Text = "man";
            }
            else if (vrouw.IsChecked == true)
            {
                newWindow.Geslacht.Text = "vrouw";
            }
            else
            {
                newWindow.Geslacht.Text = "X";
            }
              


            newWindow.Show();
        }
    }
}
