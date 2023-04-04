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

            TBlFamiliaPolzpvatelya.Text = App.dPolzovatel.Familia;
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
    }
}
