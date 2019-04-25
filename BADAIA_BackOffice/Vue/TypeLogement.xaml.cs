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
using System.Windows.Shapes;

namespace BADAIA_BackOffice.Vue
{
    /// <summary>
    /// Logique d'interaction pour TypeLogement.xaml
    /// </summary>
    public partial class TypeLogement : Window
    {
        VM.VueModeleType_Logement typeLogement = new VM.VueModeleType_Logement();
        public TypeLogement()
        {
            InitializeComponent();
        }

        private void newTL_Click(object sender, RoutedEventArgs e)
        {
            typeLogement.nouveauTypeLogement();
        }

        private void showOneTL_Click(object sender, RoutedEventArgs e)
        {
            typeLogement.afficherUnTypeLogement();
        }

        private void showAllTL_Click(object sender, RoutedEventArgs e)
        {
            typeLogement.afficherTousTypeLogement();
        }

        private void modifyTL_Click(object sender, RoutedEventArgs e)
        {
            typeLogement.modifierUnTypeLogement();
        }

        private void deleteTL_Click(object sender, RoutedEventArgs e)
        {
            typeLogement.supprimerUnTypeLogement();
        }
    }
}
