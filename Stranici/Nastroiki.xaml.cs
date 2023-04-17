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
    /// Логика взаимодействия для Nastroiki.xaml
    /// </summary>
    public partial class Nastroiki : Page
    {
        private Classi.DPolzovatel _currPolzovatel = null;

        public Nastroiki()
        {
            InitializeComponent();
        }

        public Nastroiki(Classi.DPolzovatel polzovatel)
        {
            InitializeComponent();

            _currPolzovatel = polzovatel;
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
        }
    }
}
