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
    public partial class Avtorizatia : Window
    {
        // stanimir@example.net
        // %nQvps4@01+nDEN
        // user@mail.ru
        // user1234

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
                var currPolz = App.dPolzovatel;

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
    }
}
