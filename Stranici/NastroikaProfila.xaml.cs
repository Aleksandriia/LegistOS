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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LegistOS.Stranici
{
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

            //заполнение полей существующими данными авторизированного пользователя

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
            // генерирование пароля
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

        private string ProverkaOshibok()
        {
            // обработчик ошибок

            var oshibka = new StringBuilder();

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

            if (Regex.IsMatch(TBFamilia.Text, @"[0-9!@#$%^&*()_+=?:;№\|/<>.,\[\]\{\}\]$\']")) //a-zA-Zа-яА-Я
                oshibka.AppendLine("Фамилия должна содержать только буквы;");
            if (Regex.IsMatch(TBImya.Text, @"[0-9!@#$%^&*()_+=?:;№\|/<>.,\[\]\{\}\]$\']"))
                oshibka.AppendLine("Имя должно содержать только буквы;");
            if (Regex.IsMatch(TBOtchestvo.Text, @"[0-9!@#$%^&*()_+=?:;№\|/<>.,\[\]\{\}\]$\']"))
                oshibka.AppendLine("Отчество должно содержать только буквы;");
            if (Regex.IsMatch(TBTelefon.Text, @"[a-zA-Zа-яА-Я]"))
                oshibka.AppendLine("Телефон должен содержать только цифры;");
            if (!(System.Text.RegularExpressions.Regex.IsMatch(TBPochta.Text, "[@.]")) && !(System.Text.RegularExpressions.Regex.IsMatch(TBPochta.Text, "[.]")))
                oshibka.AppendLine("Введите правильный формат почты - обязанельное использование знаков \'@ и .\';");

            if (PBParol.Password.Length > 20)
                oshibka.AppendLine("Пароль превышает максимально допустимы размер;");
            if (PBParol.Password.Length < 8)
                oshibka.AppendLine("Пароль слишком простой. Количество символов не меньше 8;");

            if (oshibka.Length > 0)
                oshibka.Insert(0, "Устраните следующие ошибки:\n");

            return oshibka.ToString();
        }

        private void BtnSohranit_Click(object sender, RoutedEventArgs e)
        {
            var soobhenieOshibok = ProverkaOshibok();
            if (soobhenieOshibok.Length > 0)
                MessageBox.Show(soobhenieOshibok, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                // сохранение измененных данных
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
}
