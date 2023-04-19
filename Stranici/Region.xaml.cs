using LegistOS.Classi;
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
    /// Логика взаимодействия для Region.xaml
    /// </summary>
    public partial class Region : Page
    {
        public Region()
        {
            InitializeComponent();

            UpdateServices();
        }

        private void UpdateServices()
        {
            var region = App.Context.DRegions.ToList();

            LVRegion.ItemsSource = region;

        }

        private void BtnYdalenie_Click(object sender, RoutedEventArgs e)
        {
            var region = (sender as Button).DataContext as Classi.DRegion;

            if (MessageBox.Show($"Вы уверены, что хотите удалить регион: " +
                $"{region.NazvanieRegiona}?", "Внимание", MessageBoxButton.YesNo,
                MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.DRegions.Remove(region);
                App.Context.SaveChanges();
                UpdateServices();
            }
        }

        private void BtnRedactirovanie_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
