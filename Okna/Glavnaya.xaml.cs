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
    /// <summary>
    /// Логика взаимодействия для Glavnaya.xaml
    /// </summary>
    public partial class Glavnaya : Window
    {
        public Glavnaya()
        {
            InitializeComponent();

            //Glavnaya glavnaya = new Glavnaya();
            //Glavnaya WindowStyle = WindowStyle{
            //    if (App.dPolzovatel.Tema == 1)
            //    {
            //        ResourceDictionary dictionary = new ResourceDictionary();
            //        dictionary.Source = new Uri("SvetlayaTema.xaml", UriKind.Relative);

            //        // Динамически меняем коллекцию MergedDictionaries
            //        Application.Current.Resources.MergedDictionaries[0] = dictionary;
            //    }
            //    else if (App.dPolzovatel.Tema == 2)
            //    {
            //        ResourceDictionary dictionary = new ResourceDictionary();
            //        dictionary.Source = new Uri("TemnayaTema.xaml", UriKind.Relative);

            //        // Динамически меняем коллекцию MergedDictionaries
            //        Application.Current.Resources.MergedDictionaries[0] = dictionary;
            //    };

            //}

            Classi.GlobalPeremen.idPolzov = App.dPolzovatel.idPolzovatelya;

            TBlFamiliaPolzpvatelya.Text = App.dPolzovatel.Familia;

            if (App.dPolzovatel.Tema == 1)
            {
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("SvetlayaTema.xaml", UriKind.Relative);

                // Динамически меняем коллекцию MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }
            else if (App.dPolzovatel.Tema == 2)
            {
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("TemnayaTema.xaml", UriKind.Relative);

                // Динамически меняем коллекцию MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }

            FrameMain.Navigate(new Stranici.PravovayaBaza());

            
            //glavnaya.Show();
            //this.Close();

        }

        private void Glavnaya_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            throw new NotImplementedException();
        }

        //public Glavnaya(Classi.DPolzovate polzovate )
        //{
        //    InitializeComponent();
        //}

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

                // Динамически меняем коллекцию MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }
            else if (App.dPolzovatel.Tema == 2)
            {
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("TemnayaTema.xaml", UriKind.Relative);

                // Динамически меняем коллекцию MergedDictionaries
                Application.Current.Resources.MergedDictionaries[0] = dictionary;
            }
        }

        private void BtnVMIzdOrgani_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new Stranici.IzdOrgani());
        }
    }
}
