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

namespace LegistOS.Stranici
{
    /// <summary>
    /// Логика взаимодействия для OpisanieIzdOrgana.xaml
    /// </summary>
    public partial class OpisanieIzdOrgana : Page
    {
        private Classi.DIzdavOrgan dIzdavOrgan = null;

        public OpisanieIzdOrgana()
        {
            InitializeComponent();
        }

        public OpisanieIzdOrgana(Classi.DIzdavOrgan izdavOrgan)
        {
            InitializeComponent();

            TBOpisanieIzdOrgana.Text = izdavOrgan.OpisanieOrgana;
            TBlNazvanieIzdOrg.Text = izdavOrgan.NazvanieOrgana;
        }

        private void BtnNazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
