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
using System.Windows.Shapes;

namespace LegistOS.Okna
{
    /// <summary>
    /// Логика взаимодействия для Avtorizatia.xaml
    /// </summary>
    public partial class Avtorizatia : Window
    {
        public Avtorizatia()
        {
            InitializeComponent();

            TBPochta.Focus();
        }

        private void BtnRegistratia_Click(object sender, RoutedEventArgs e)
        {
            Registratia registratia = new Registratia();
            registratia.Show();
            this.Close();
        }

        private void BtnVhod_Click(object sender, RoutedEventArgs e)
        {
            var polzovatel = App.Context.DPolzovatels.FirstOrDefault(p => p.Pochta == TBPochta.Text && p.Parol == PBParol.Password);

            if (polzovatel != null)
            {
                App.dPolzovatel = polzovatel;

                //MessageBox.Show(polzovatel.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                Okna.Glavnaya glavnaya = new Okna.Glavnaya();
                glavnaya.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь с такими данными не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                TBPochta.Focus();
            }
        }

        private void BtnZapolnenie_Click(object sender, RoutedEventArgs e)
        {
            TBPochta.Text = "stanimir@example.net";
            PBParol.Password = "%nQvps4@01+nDEN";
        }
    }
}
