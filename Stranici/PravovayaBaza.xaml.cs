﻿using System;
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
    public partial class PravovayaBaza : Page
    {
        public PravovayaBaza()
        {
            InitializeComponent();

            if (App.dPolzovatel.Rol == 1)
            {
                BtnDobavlenie.Visibility = Visibility.Visible;
            }
            else
            {
                BtnDobavlenie.Visibility = Visibility.Collapsed;
            }

            UpdateServices();
        }

        private void UpdateServices()
        {
            var docs = App.Context.DDocuments.ToList();

            docs = docs.Where(p => p.Nazvanie.ToLower().Contains(TBoxPoisk.Text.ToLower()) ||
                              p.KratOpisanie.ToLower().Contains(TBoxPoisk.Text.ToLower()) ||
                              p.Nomer.ToLower().Contains(TBoxPoisk.Text.ToLower())).ToList();

            if (Classi.Bazi.Vibrano > 0)
            {
                docs = docs.Where(p => p.NPA == Classi.Bazi.Vibrano).ToList();
            }


            LVPravovayaBaza.ItemsSource = docs;


            /* Боковое меню */
            var npa = App.Context.DNPAs.ToList();

            /* Вывод количества записей */
            TBlKolvoZapisey.Text = "Найдено записей: " + docs.Count.ToString();
        }

        private void BtnVsyaBaza_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 0;
            UpdateServices();
        }

        private void BtnConstitutiya_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 1;
            UpdateServices();
        }

        private void BtnFederalnaya_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 2;
            UpdateServices();
        }

        private void BtnYkaziPrezidentaRF_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 3;
            UpdateServices();
        }

        private void BtnPostanovleniya_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 4;
            UpdateServices();
        }

        private void BtnNormativnieActi_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 5;
            UpdateServices();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }

        private void BtnPodrobnee_Click(object sender, RoutedEventArgs e)
        {
            var document = (sender as Button).DataContext as Classi.DDocument;
            NavigationService.Navigate( new Stranici.Document(document));
        }

        private void BtnRashirPoisk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Stranici.PravovayaBazaRashirPoisk());
        }

        private void BtnRedactirovanie_Click(object sender, RoutedEventArgs e)
        {
            Classi.GlobalPeremen.dobRedDoc = 2;
            var ddoc = (sender as Button).DataContext as Classi.DDocument;
            NavigationService.Navigate(new Stranici.DobavlenieRedaktirovanieDoc(ddoc));
        }

        private void BtnYdalenie_Click(object sender, RoutedEventArgs e)
        {
            var docc = (sender as Button).DataContext as Classi.DDocument;

            if (MessageBox.Show($"Вы уверены, что хотите удалить документ№: " + 
                $"{docc.Nomer}?", "Внимание", MessageBoxButton.YesNo, 
                MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.DDocuments.Remove(docc);
                App.Context.SaveChanges();
                UpdateServices();
            }
        }

        private void BtnDobavlenie_Click(object sender, RoutedEventArgs e)
        {
            Classi.GlobalPeremen.dobRedDoc = 1;
            NavigationService.Navigate(new Stranici.DobavlenieRedaktirovanieDoc());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateServices();
        }
    }
}
