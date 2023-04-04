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
        public Nastroiki()
        {
            InitializeComponent();
        }

        private void BtnNastroikaProfila_Click(object sender, RoutedEventArgs e)
        {
            var currPolz = App.dPolzovatel;
            NavigationService.Navigate(new Stranici.NastroikaProfila(currPolz));

            //var currentService = (sender as Button).DataContext as Entities.Service;
            //NavigationService.Navigate(new ZapisPage(currentService));
        }
    }
}
