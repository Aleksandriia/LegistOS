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
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class Vid : Page
    {
        public Vid()
        {
            InitializeComponent();

            UpdateServices();
        }

        private void UpdateServices()
        {
            var vid = App.Context.DVids.ToList();

            LVVid.ItemsSource = vid;

        }

        private void BtnRedactirovanie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnYdalenie_Click(object sender, RoutedEventArgs e)
        {
            var vid = (sender as Button).DataContext as Classi.DVid;

            if (MessageBox.Show($"Вы уверены, что хотите удалить вид: " +
                $"{vid.NazvanieVida}?", "Внимание", MessageBoxButton.YesNo,
                MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.DVids.Remove(vid);
                App.Context.SaveChanges();
                UpdateServices();
            }
        }
    }
}
