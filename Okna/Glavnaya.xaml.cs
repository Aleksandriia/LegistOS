using LegistOS.Classi;
using LegistOS.Stranici;
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

namespace LegistOS.Okna
{
    public partial class Glavnaya : Window
    {
        public Glavnaya()
        {
            InitializeComponent();

            Classi.GlobalPeremen.idPolzov = App.dPolzovatel.idPolzovatelya;

            TBlFamiliaPolzpvatelya.Text = App.dPolzovatel.Familia;

            if (App.dPolzovatel.Tema == 1)
            {
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("SvetlayaTema.xaml", UriKind.Relative);

                // Динамическая смена коллекции MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }
            else if (App.dPolzovatel.Tema == 2)
            {
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("TemnayaTema.xaml", UriKind.Relative);

                // Динамическая смена коллекции MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }

            Classi.GlobalPeremen.FIO = null;
            Classi.GlobalPeremen.FIO = App.dPolzovatel.Familia + " " + App.dPolzovatel.Imya + " " + App.dPolzovatel.Otchestvo;

            FrameMain.Navigate(new Stranici.PravovayaBaza());
        }

        private void Glavnaya_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnVMNastroiki_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate (new Stranici.Nastroiki());
        }

        private void BtnVihod_Click(object sender, RoutedEventArgs e)
        {
            Avtorizatia avtorizatia = new Avtorizatia();
            avtorizatia.Show();
            this.Close();
        }

        private void BtnVMPravBaza_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new Stranici.PravovayaBaza());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.dPolzovatel.Tema == 1)
            {
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("SvetlayaTema.xaml", UriKind.Relative);

                // Динамическая смена коллекции MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }
            else if (App.dPolzovatel.Tema == 2)
            {
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("TemnayaTema.xaml", UriKind.Relative);

                // Динамическая смена коллекции MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }
        }

        private void BtnVMIzdOrgani_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new Stranici.IzdOrgani());
        }

        private void BtnVMInformatia_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new Stranici.Pomosh());
        }
    }
}
