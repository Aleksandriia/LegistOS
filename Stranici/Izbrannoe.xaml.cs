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
    public partial class Izbrannoe : Page
    {
        private Classi.DIzbrannoe dIzbrannoe = null;

        public Izbrannoe()
        {
            InitializeComponent();

            UpdateServices();
        }

        private void UpdateServices()
        {
            var izbrannoe = App.Context.DIzbrannoes.ToList();

            izbrannoe = izbrannoe.Where(p => p.idPolzovatelya == App.dPolzovatel.idPolzovatelya).ToList();

            LVIzbrannoe.ItemsSource = izbrannoe;
        }

        private void BtnYdalenie_Click(object sender, RoutedEventArgs e)
        {
            var izbran = (sender as Button).DataContext as Classi.DIzbrannoe;

            if (MessageBox.Show($"Вы уверены, что хотите удалить документ: " +
                $"{izbran.DDocument.Nazvanie}?", "Внимание", MessageBoxButton.YesNo,
                MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.DIzbrannoes.Remove(izbran);
                App.Context.SaveChanges();
                UpdateServices();
            }
        }

        private void BtnPodrobnee_Click(object sender, RoutedEventArgs e)
        {
            var iz = (sender as Button).DataContext as Classi.DIzbrannoe;
            Classi.GlobalPeremen.IDdoc = iz.idDocumenta;
            NavigationService.Navigate(new Stranici.DocumentIzbrann(iz.DDocument));
        }
    }
}
