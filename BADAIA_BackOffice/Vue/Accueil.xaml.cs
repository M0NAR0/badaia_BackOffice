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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void ClearGrid()
        {
            this.MainList.Children.Clear();
            this.ShowButtons.Visibility = Visibility.Hidden;
        }

        private void TypeLogement_Click(object sender, RoutedEventArgs e)
        {
            ClearGrid();
            this.MainList.Children.Add(new Vue.ListTypeLogement());
            this.ShowButtons.Visibility = Visibility.Visible;
        }

        private void Deconnexion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
