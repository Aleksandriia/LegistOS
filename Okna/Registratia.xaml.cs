using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Registratia.xaml
    /// </summary>
    public partial class Registratia : Window
    {
        private Classi.DPolzovatel _dPolzovatel = null;

        public Registratia()
        {
            InitializeComponent();

            TBFamilia.Focus();

            if (ChBPrinatVse.IsChecked == true)
            {
                BtnRegistratia.IsEnabled = true;
            }
            else if (ChBPrinatVse.IsChecked == false)
            {
                BtnRegistratia.IsEnabled = false;
            }
            else if (ChBPrinatVse.IsChecked != true)
            {
                BtnRegistratia.IsEnabled = false;
            }
        }

        private void BtnProsmotrParolya_Click(object sender, RoutedEventArgs e)
        {
            if (PBParol.Password.Length > 20)
            {
                MessageBox.Show("Пароль превышает максимально допустимы размер!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                PBParol.Focus();
            }
            else 
            {
                BtnSkritParol.Visibility = Visibility.Visible;
                TBlParolProsmotr.Visibility = Visibility.Visible;

                //PBParol.PasswordChar = null;

                TBlParolProsmotr.Text = PBParol.Password.ToString();
            }
            
        }

        private void BtnSkritParol_Click(object sender, RoutedEventArgs e)
        {
            BtnSkritParol.Visibility = Visibility.Hidden;
            TBlParolProsmotr.Visibility = Visibility.Hidden;
        }

        private void BtnKopirovanieParola_Click(object sender, RoutedEventArgs e)
        {
            /*string parol = PBParol.Password;
            Clipboard.SetText(parol);*/

            //Clipboard.SetText(TBFamilia.Text);

            //PBParol.Password.ToString().CopyTo();
            //PBParol.Password.ToString().CopyTo(0, 'a', 4, 4);
            //ApplicationCommands.Copy.Text.ToString();
            //    {
            //        PBParol.Password.ToString();
            //};
        }

        private static string GeneratorParola (int dlina)
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

        private void BtnSoglashenia_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавить окно с соглашениями!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void BtnAvtorizatia_Click(object sender, RoutedEventArgs e)
        {
            Avtorizatia avtorizatia = new Avtorizatia();
            avtorizatia.Show();
            this.Close();
        }

        private void BtnRegistratia_Click(object sender, RoutedEventArgs e)
        {
            if (ChBPrinatVse.IsChecked == true)
            {
                BtnRegistratia.IsEnabled = true;
                var polzpvatel = new Classi.DPolzovatel
                {
                    Familia = TBFamilia.Text,
                    Imya = TBImya.Text,
                    Otchestvo = TBOtchestvo.Text,
                    Telefon = TBTelefon.Text,
                    Pochta = TBPochta.Text,
                    Parol = PBParol.Password,
                    Rol = 2
                };

                App.Context.DPolzovatels.Add(polzpvatel);
                App.Context.SaveChanges();
                MessageBox.Show("Данные успешно добавлены.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                Avtorizatia avtorizatia = new Avtorizatia();
                avtorizatia.Show();
                this.Close();
            }
            else if (ChBPrinatVse.IsChecked == false)
            {
                BtnRegistratia.IsEnabled = false;
                //ChBPrinatVse.BorderBrush = BorderBrush.
            }
            else if (ChBPrinatVse.IsChecked != true)
            {
                BtnRegistratia.IsEnabled = false;
            }

        }

        private void ChBPrinatVse_Checked(object sender, RoutedEventArgs e)
        {
            if (ChBPrinatVse.IsChecked == true)
            {
                BtnRegistratia.IsEnabled = true;
            }
            else if (ChBPrinatVse.IsChecked == false)
            {
                BtnRegistratia.IsEnabled = false;
            }
            else if (ChBPrinatVse.IsChecked != true)
            {
                BtnRegistratia.IsEnabled = false;
            }
        }
    }
}
