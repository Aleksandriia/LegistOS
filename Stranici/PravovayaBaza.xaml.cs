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
    /// Логика взаимодействия для PravovayaBaza.xaml
    /// </summary>
    public partial class PravovayaBaza : Page
    {
        public PravovayaBaza()
        {
            InitializeComponent();

            UpdateServices();
        }

        private void UpdateServices()
        {
            var docs = App.Context.DDocuments.ToList();

            docs = docs.Where(p => p.Nazvanie.ToLower().Contains(TBoxPoisk.Text.ToLower())).ToList();
            if (Classi.Bazi.Vibrano > 0)
            {
                docs = docs.Where(p => p.NPA == Classi.Bazi.Vibrano).ToList();
            }


            LVPravovayaBaza.ItemsSource = docs;


            /* Боковое меню */
            var npa = App.Context.DNPAs.ToList();

            //LViewNLA.ItemsSource = nla;
        }

        private void BtnVsyaBaza_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 0;
            UpdateServices();
        }

        private void BtnConstitutiya_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 1;
            UpdateServices();
        }

        private void BtnFederaLaws_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 2;
            UpdateServices();
        }

        private void BtnPresidentialDecrees_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 3;
            UpdateServices();
        }

        private void BtnGovernmentDecrees_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 4;
            UpdateServices();
        }

        private void BtnNormativeAct_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 5;
            UpdateServices();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }

        private void BtnPodrobnee_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
