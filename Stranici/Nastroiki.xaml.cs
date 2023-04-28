using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Nastroiki.xaml
    /// </summary>
    public partial class Nastroiki : Page
    {
        private Classi.DPolzovatel _currPolzovatel = null;

        public Nastroiki()
        {
            InitializeComponent();

            if (App.dPolzovatel.Rol == 1)
            {
                BtnIzdOrgan.Visibility = Visibility.Visible;
                BtnRegion.Visibility = Visibility.Visible;
                BtnVid.Visibility = Visibility.Visible;
            }
            else
            {
                BtnIzdOrgan.Visibility = Visibility.Collapsed;
                BtnRegion.Visibility = Visibility.Collapsed;
                BtnVid.Visibility = Visibility.Collapsed;
            }

            if (App.dPolzovatel.Tema == 1)
                BtnSvetlaya.Background = (Brush)(new BrushConverter().ConvertFrom("#5EADBC"));
            else if (App.dPolzovatel.Tema == 2)
                BtnTemnaya.Background = (Brush)(new BrushConverter().ConvertFrom("#146675"));
        }

        public Nastroiki(Classi.DPolzovatel polzovatel)
        {
            InitializeComponent();

            _currPolzovatel = polzovatel;
            if (App.dPolzovatel.Tema == 1)
                BtnSvetlaya.Background = (Brush)(new BrushConverter().ConvertFrom("#5EADBC"));
            else if (App.dPolzovatel.Tema == 2)
                BtnTemnaya.Background = (Brush)(new BrushConverter().ConvertFrom("#146675"));
            
        }

        private void BtnNastroikaProfila_Click(object sender, RoutedEventArgs e)
        {
            var currPolz = App.dPolzovatel;
            NavigationService.Navigate(new Stranici.NastroikaProfila(currPolz));

            //var currentService = (sender as Button).DataContext as Entities.Service;
            //NavigationService.Navigate(new ZapisPage(currentService));
        }

        private void BtnTemnaya_Click(object sender, RoutedEventArgs e)
        {
            //_currPolzovatel.Tema = 2;
            App.dPolzovatel.Tema = 2;

            App.Context.SaveChanges();
            //MessageBox.Show("Тема успешно изменена.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("TemnayaTema.xaml", UriKind.Relative);

            // Динамически меняем коллекцию MergedDictionaries
            Application.Current.Resources.MergedDictionaries[0] = dictionary;

            BtnTemnaya.Background = (Brush)(new BrushConverter().ConvertFrom("#146675"));
            BtnSvetlaya.Background = (Brush)(new BrushConverter().ConvertFrom("#1DAFCA"));
            BtnNastroikaProfila.Background = (Brush)(new BrushConverter().ConvertFrom("#1DAFCA"));
            TBZagolovokN.Foreground = new SolidColorBrush(Colors.White);
            SPVerhPolojka.Background = (Brush)(new BrushConverter().ConvertFrom("#474747"));
            RtgBokMeny.Fill = (Brush)(new BrushConverter().ConvertFrom("#474747"));
            //BtnIzdOrgan.Background = (Brush)(new BrushConverter().ConvertFrom("#748C90"));
            //BtnRegion.Background = (Brush)(new BrushConverter().ConvertFrom("#748C90"));
            //BtnVid.Background = (Brush)(new BrushConverter().ConvertFrom("#748C90"));
            SPVid.Background = (Brush)(new BrushConverter().ConvertFrom("#748C90"));
            SPIzdOrg.Background = (Brush)(new BrushConverter().ConvertFrom("#748C90"));
            SPRegion.Background = (Brush)(new BrushConverter().ConvertFrom("#748C90"));
            TBlRegion.Foreground = new SolidColorBrush(Colors.White);
            TBlIzdOrg.Foreground = new SolidColorBrush(Colors.White);
            TBlVid.Foreground = new SolidColorBrush(Colors.White);
        }

        private void BtnSvetlaya_Click(object sender, RoutedEventArgs e)
        {
            //_currPolzovatel.Tema = 1;
            App.dPolzovatel.Tema = 1;

            App.Context.SaveChanges();
            //MessageBox.Show("Тема успешно изменена.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("SvetlayaTema.xaml", UriKind.Relative);

            // Динамически меняем коллекцию MergedDictionaries
            Application.Current.Resources.MergedDictionaries[0] = dictionary;

            BtnSvetlaya.Background = (Brush)(new BrushConverter().ConvertFrom("#5EADBC"));
            BtnTemnaya.Background = (Brush)(new BrushConverter().ConvertFrom("#55DFF9"));
            BtnNastroikaProfila.Background = (Brush)(new BrushConverter().ConvertFrom("#55DFF9"));
            TBZagolovokN.Foreground = new SolidColorBrush(Colors.Black);
            SPVerhPolojka.Background = (Brush)(new BrushConverter().ConvertFrom("#F4F4F4")); 
            RtgBokMeny.Fill = (Brush)(new BrushConverter().ConvertFrom("#F4F4F4")); 
            //BtnIzdOrgan.Background = (Brush)(new BrushConverter().ConvertFrom("#FFCCE9F0"));
            //BtnRegion.Background = (Brush)(new BrushConverter().ConvertFrom("#FFCCE9F0"));
            //BtnVid.Background = (Brush)(new BrushConverter().ConvertFrom("#FFCCE9F0"));
            SPVid.Background = (Brush)(new BrushConverter().ConvertFrom("#FFCCE9F0"));
            SPIzdOrg.Background = (Brush)(new BrushConverter().ConvertFrom("#FFCCE9F0"));
            SPRegion.Background = (Brush)(new BrushConverter().ConvertFrom("#FFCCE9F0"));
            TBlRegion.Foreground = new SolidColorBrush(Colors.Black);
            TBlIzdOrg.Foreground = new SolidColorBrush(Colors.Black);
            TBlVid.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void BtnRegion_Click(object sender, RoutedEventArgs e)
        {
            FrameIzdOrganVidRegion.Navigate(new Stranici.Region());
        }

        private void BtnVid_Click(object sender, RoutedEventArgs e)
        {
            FrameIzdOrganVidRegion.Navigate(new Stranici.Vid());
        }

        private void BtnIzdOrgan_Click(object sender, RoutedEventArgs e)
        {
            FrameIzdOrganVidRegion.Navigate(new Stranici.IzdOrgan());
        }
    }
}
