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

        private static string GeneratorParola(int dlina)
        {
            // генерация пароля

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

        private string ProverkaOshibok()
        {
            // обработчик ошибок

            var oshibka = new StringBuilder();

            var povtor = App.Context.DPolzovatels.ToList().FirstOrDefault(p => p.Pochta.ToLower() == TBPochta.Text.ToLower());
            if (povtor != null && povtor != _dPolzovatel)
                oshibka.AppendLine("Аккаунт с такой почтой уже существует;");

            if (ChBPrinatVse.IsChecked == false)
                oshibka.AppendLine("Необходимо принять условия использования приложения;");

            if (string.IsNullOrWhiteSpace(TBFamilia.Text))
                oshibka.AppendLine("Поле Фамилия обязательно для заполнения;");
            if (string.IsNullOrWhiteSpace(TBImya.Text))
                oshibka.AppendLine("Поле Имя обязательно для заполнения;");
            if (string.IsNullOrWhiteSpace(TBTelefon.Text))
                oshibka.AppendLine("Поле Телефон обязательно для заполнения;");
            if (string.IsNullOrWhiteSpace(TBPochta.Text))
                oshibka.AppendLine("Поле Почта обязательно для заполнения;");
            if (string.IsNullOrWhiteSpace(PBParol.Password))
                oshibka.AppendLine("Поле Пароль обязательно для заполнения;");

            if (Regex.IsMatch(TBFamilia.Text, @"[0-9!@#$%^&*()_+=?:;№\|/<>.,\[\]\{\}\]$\']"))
                oshibka.AppendLine("Фамилия должна содержать только буквы;");
            if (Regex.IsMatch(TBImya.Text, @"[0-9!@#$%^&*()_+=?:;№\|/<>.,\[\]\{\}\]$\']"))
                oshibka.AppendLine("Имя должно содержать только буквы;");
            if (Regex.IsMatch(TBOtchestvo.Text, @"[0-9!@#$%^&*()_+=?:;№\|/<>.,\[\]\{\}\]$\']"))
                oshibka.AppendLine("Отчество должно содержать только буквы;");
            if (Regex.IsMatch(TBTelefon.Text, @"[a-zA-Zа-яА-Я]"))
                oshibka.AppendLine("Телефон должен содержать только цифры;");
            if (!(System.Text.RegularExpressions.Regex.IsMatch(TBPochta.Text, "[@.]")) && !(System.Text.RegularExpressions.Regex.IsMatch(TBPochta.Text, "[.]")))
                oshibka.AppendLine("Введите правильный формат почты - обязательное использование знаков \'@ и .\';");

            if (PBParol.Password.Length > 20)
                oshibka.AppendLine("Пароль превышает максимально допустимы размер;");
            if (PBParol.Password.Length < 8)
                oshibka.AppendLine("Пароль слишком простой. Количество символов не меньше 8;");
            if (TBTelefon.Text.Length != 11)
                oshibka.AppendLine("Телефон должен состоять из 11 цифр, пример: 89998887766;");

            if (oshibka.Length > 0)
                oshibka.Insert(0, "Устраните следующие ошибки:\n");

            return oshibka.ToString();
        }

        private void BtnRegistratia_Click(object sender, RoutedEventArgs e)
        {
            var soobhenieOshibok = ProverkaOshibok();
            if (soobhenieOshibok.Length > 0)
                MessageBox.Show(soobhenieOshibok, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                BtnRegistratia.IsEnabled = true;

                // добавление пользователя в бд по внесенным данным

                var polzpvatel = new Classi.DPolzovatel
                {
                    Familia = TBFamilia.Text,
                    Imya = TBImya.Text,
                    Otchestvo = TBOtchestvo.Text,
                    Telefon = TBTelefon.Text,
                    Pochta = TBPochta.Text,
                    Parol = PBParol.Password,
                    Rol = 2,
                    Tema = 1
                };

                App.Context.DPolzovatels.Add(polzpvatel);
                App.Context.SaveChanges();
                MessageBox.Show("Данные успешно добавлены.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                Avtorizatia avtorizatia = new Avtorizatia();
                avtorizatia.Show();
                this.Close();
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
