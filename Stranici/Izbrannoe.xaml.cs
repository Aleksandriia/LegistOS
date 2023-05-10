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
    /// Логика взаимодействия для Izbrannoe.xaml
    /// </summary>
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
            //izbrannoe = izbrannoe.Where(p => p.idDocumenta).ToList();

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
            //dIzbrannoe.idDocumenta

            var iz = (sender as Button).DataContext as Classi.DIzbrannoe;
            Classi.GlobalPeremen.IDdoc = iz.idDocumenta;
            NavigationService.Navigate(new Stranici.DocumentIzbrann(iz.DDocument));
            //Nastroiki nastroiki = Window.GetWindow(Nastroiki.Frame);
            //Nastroiki.FrameIzdOrganVidRegionIzbrannoe.NavigationService.Navigate(new Stranici.Document(iz.DDocument));
            //MessageBox.Show(Classi.GlobalPeremen.IDdoc.ToString());
            //var izbran = (sender as Button).DataContext as Classi.DDocument;
            //Nastroiki.FrameIzdOrganVidRegionIzbrannoe.NavigationService.Navigate(new Stranici.Document(iz.DDocument));
            //NavigationService.Refresh(Stranici.Izbrannoe => new Stranici.Document(iz.DDocument));

            //Nastroiki nastroiki = (Nastroiki)Window.FrameIzdOrganVidRegionIzbrannoe.Source(new Stranici.Document(iz.DDocument));
            //nastroiki.FrameIzdOrganVidRegionIzbrannoe.Navigate(new Stranici.Document(iz.DDocument));

            //Nastroiki nastroiki = (Nastroiki)this.Content;
            //Nastroiki nastroiki = NavigationService.Navigate(Nastroiki.FrameIzdOrganVidRegionIzbrannoe);
            //Nastroiki nastroiki = new Nastroiki();
            //nastroiki.FrameIzdOrganVidRegionIzbrannoe.Navigate(new Stranici.Document(iz.DDocument));
        }

        /*private void BtnPodrobnee_Click(object sender, RoutedEventArgs e)
        {
            //Classi.GlobalPeremen.IDdoc = Izbrannoe.id
            var izbran = (sender as Button).DataContext as Classi.DDocument;
            if (izbran = izbran.Where(izbran.idDocumenta == Classi.GlobalPeremen.IDdoc))
                NavigationService.Navigate(new Stranici.Document(izbran));
            //var document = (sender as Button).DataContext as Classi.DDocument;
            //document = DDocument.Equals(document.idDocumenta == )
            //NavigationService.Navigate(new Stranici.Document(izbran));
        }*/
    }
}
