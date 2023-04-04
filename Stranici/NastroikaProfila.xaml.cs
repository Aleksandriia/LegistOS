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
    /// Логика взаимодействия для NastroikaProfila.xaml
    /// </summary>
    public partial class NastroikaProfila : Page
    {
        private Classi.DPolzovatel _currPolzovatel = null;

        public NastroikaProfila()
        {
            InitializeComponent();
        }

        public NastroikaProfila(Classi.DPolzovatel polzovatel)
        {
            InitializeComponent();

            _currPolzovatel = polzovatel;

            TBFamilia.Text = _currPolzovatel.Familia;
            TBImya.Text = _currPolzovatel.Imya;
            TBOtchestvo.Text = _currPolzovatel.Otchestvo;
            TBTelefon.Text = _currPolzovatel.Telefon;
            TBPochta.Text = _currPolzovatel.Pochta;
            PBParol.Password = _currPolzovatel.Parol;
        }

        private static string GeneratorParola(int dlina)
        {
            string parol = "";
            string simvoli = "qwertyuiopasdfghjklzxcvbnm" + "1234567890" + "!#$%&*?" + "QWERTYUIOPASDFGHJKLZXCVBNM";

            Random random = new Random();

            for (int i = 0; i < dlina; i++)
            {
                parol += simvoli[random.Next(0, simvoli.Length)];
            }
            return parol;
        }

        private void BtnGenerirovanieParola_Click(object sender, RoutedEventArgs e)
        {
            PBParol.Password = GeneratorParola(12);
        }

        private void BtnNazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnSohranit_Click(object sender, RoutedEventArgs e)
        {
            _currPolzovatel.Familia = TBFamilia.Text;
            _currPolzovatel.Imya = TBImya.Text;
            _currPolzovatel.Otchestvo = TBOtchestvo.Text;
            _currPolzovatel.Telefon = TBTelefon.Text;
            _currPolzovatel.Pochta = TBPochta.Text;
            _currPolzovatel.Parol = PBParol.Password;

            App.Context.SaveChanges();
            MessageBox.Show("Изменения успешно внесены.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
    }
}
