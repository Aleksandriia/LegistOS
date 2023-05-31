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
    public partial class IzdOrgan : Page
    {
        public IzdOrgan()
        {
            InitializeComponent();

            UpdateServices();
        }

        private void UpdateServices()
        {
            var organ = App.Context.DIzdavOrgans.ToList();

            LVIzdOrgan.ItemsSource = organ;

        }

        private void BtnYdalenie_Click(object sender, RoutedEventArgs e)
        {
            var organ = (sender as Button).DataContext as Classi.DIzdavOrgan;

            if (MessageBox.Show($"Вы уверены, что хотите удалить регион: " +
                $"{organ.NazvanieOrgana}?", "Внимание", MessageBoxButton.YesNo,
                MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.DIzdavOrgans.Remove(organ);
                App.Context.SaveChanges();
                UpdateServices();
            }
        }
    }
}
