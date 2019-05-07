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

namespace BADAIA_BackOffice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void connexion_Click(object sender, RoutedEventArgs e)
        {
            Modele.Donnees db = new Modele.Donnees();
            
            VM.VueModeleUtilisateur userVM = new VM.VueModeleUtilisateur();
            
            if(userVM.tryToLogIn(Mail.Text, Password.Password) == true)
            {
                Vue.Accueil accueil = new Vue.Accueil();
                accueil.Show();
                this.Close();
            }
        }
    }
}
