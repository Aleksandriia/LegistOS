﻿using LegistOS.Classi;
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
    public partial class PravovayaBazaRashirPoisk : Page
    {
        public PravovayaBazaRashirPoisk()
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

            CBVidDoc.ItemsSource = App.Context.DVids.ToList();
            CBTegDoc.ItemsSource = App.Context.DTegs.ToList();
            CBOrgenDoc.ItemsSource = App.Context.DIzdavOrgans.ToList();
            CBRegionDoc.ItemsSource = App.Context.DRegions.ToList();
            CBStatusDoc.ItemsSource = App.Context.DStatus.ToList();
            CBPravovayaBaza.ItemsSource = App.Context.DPravovayaBazas.ToList();

            UpdateServices();
        }

        private void UpdateServices()
        {
            var docs = App.Context.DDocuments.ToList();
            var tegs = App.Context.DTegs;

            // Поиск по номеру документа и дате
            docs = docs.Where(p => p.Nomer.ToLower().Contains(Classi.GlobalPeremen.nomerDocs.ToLower())).ToList();
            docs = docs.Where(p => p.DataNach.ToString().Contains(Classi.GlobalPeremen.NachData.ToLower())).ToList();
            docs = docs.Where(p => p.DataKon.ToString().Contains(Classi.GlobalPeremen.konData.ToLower())).ToList();

            docs = docs.Where(p => p.Nazvanie.ToLower().Contains(TBoxPoisk.Text.ToLower())).ToList();
            if (Classi.Bazi.Vibrano > 0)
            {
                docs = docs.Where(p => p.NPA == Classi.Bazi.Vibrano).ToList();
            }

            // Поиск с comboBox-ами
            if (CBVidDoc.SelectedIndex == -1) {  }
            else if (CBVidDoc.SelectedIndex != -1)
            {
                docs = docs.Where(p => p.VidDoc.ToString().Equals(Classi.GlobalPeremen.vidDocs.ToString())).ToList();
            }

            if (CBTegDoc.SelectedIndex == -1) {  }
            else if (CBTegDoc.SelectedIndex != -1)
            {
                docs = docs.Where(p => p.Teg.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString())).ToList();
            }

            if (CBOrgenDoc.SelectedIndex == -1) {  }
            else if (CBOrgenDoc.SelectedIndex != -1)
            {
                docs = docs.Where(p => p.IzdavOrgan.ToString().Equals(Classi.GlobalPeremen.IzdOrganDocs.ToString())).ToList();
            }

            if (CBRegionDoc.SelectedIndex == -1) {  }
            else if (CBRegionDoc.SelectedIndex != -1)
            {
                docs = docs.Where(p => p.Region.ToString().Equals(Classi.GlobalPeremen.regionDocs.ToString())).ToList();
            }

            if (CBStatusDoc.SelectedIndex == -1) { }
            else if (CBStatusDoc.SelectedIndex != -1)
            {
                docs = docs.Where(p => p.Status.ToString().Equals(Classi.GlobalPeremen.statusDocs.ToString())).ToList();
            }

            if (CBPravovayaBaza.SelectedIndex == -1) { }
            else if (CBPravovayaBaza.SelectedIndex != -1)
            {
                docs = docs.Where(p => p.PravovayaBaza.ToString().Equals(Classi.GlobalPeremen.pravovayaBaza.ToString())).ToList();
            }

            LVPravovayaBaza.ItemsSource = docs;

            /* Боковое меню */
            var npa = App.Context.DNPAs.ToList();

            /* Вывод количества записей */
            TBlKolvoZapisey.Text = "Найдено записей: " + docs.Count.ToString();
        }

        private void BtnObichPoisk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Stranici.PravovayaBaza());
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
            var docs = App.Context.DDocuments.ToList();

            docs = docs.Where(p => p.Nazvanie.ToLower().Contains(TBoxPoisk.Text.ToLower()) ||
                              p.KratOpisanie.ToLower().Contains(TBoxPoisk.Text.ToLower()) ||
                              p.Nomer.ToLower().Contains(TBoxPoisk.Text.ToLower())).ToList();

            LVPravovayaBaza.ItemsSource = docs;

            /* Вывод количества записей */
            TBlKolvoZapisey.Text = "Найдено записей: " + docs.Count.ToString();
        }

        private void BtnPodrobnee_Click(object sender, RoutedEventArgs e)
        {
            var document = (sender as Button).DataContext as Classi.DDocument;
            NavigationService.Navigate(new Stranici.Document(document));
        }

        private void CBVidDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBTegDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBOrgenDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBRegionDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnNayti_Click(object sender, RoutedEventArgs e)
        {
            var soobhenieOshibki = ProverkaOshibok();
            if (soobhenieOshibki.Length > 0)
                MessageBox.Show(soobhenieOshibki, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                Classi.GlobalPeremen.nomerDocs = TBNomer.Text;
                Classi.GlobalPeremen.NachData = TBDataNach.Text;
                Classi.GlobalPeremen.konData = TBDataKon.Text;

                Classi.GlobalPeremen.vidDocs = CBVidDoc.SelectedIndex + 1;
                Classi.GlobalPeremen.tegDocs = CBTegDoc.SelectedIndex + 1;
                Classi.GlobalPeremen.IzdOrganDocs = CBOrgenDoc.SelectedIndex + 1;
                Classi.GlobalPeremen.regionDocs = CBRegionDoc.SelectedIndex + 1;
                Classi.GlobalPeremen.statusDocs = CBStatusDoc.SelectedIndex + 1;
                Classi.GlobalPeremen.pravovayaBaza = CBPravovayaBaza.SelectedIndex + 1;

                UpdateServices();
            }
        }

        private string ProverkaOshibok()
        {
            // обработчик ошибок

            var proverkavvoda = new StringBuilder();

            if (TBNomer.Text != "")
            {
                int nDoc = 0;
                if (int.TryParse(TBNomer.Text, out nDoc) == false || nDoc <= 0)
                    proverkavvoda.AppendLine("Номер документа должен быть положительным числом;");
            }

            if (proverkavvoda.Length > 0)
                proverkavvoda.Insert(0, "Устраните следующие ошибки:\n");

            return proverkavvoda.ToString();
        }

        private void BtnSbros_Click(object sender, RoutedEventArgs e)
        {
            TBNomer.Text = "";
            TBDataNach.Text = "";
            TBDataKon.Text = "";

            CBVidDoc.Text = "";
            CBTegDoc.Text = "";
            CBOrgenDoc.Text = "";
            CBRegionDoc.Text = "";
            CBStatusDoc.Text = "";
            CBPravovayaBaza.Text = "";

            Classi.GlobalPeremen.nomerDocs = TBNomer.Text;
            Classi.GlobalPeremen.NachData = TBDataNach.Text;
            Classi.GlobalPeremen.konData = TBDataKon.Text;
            Classi.GlobalPeremen.vidDocs = Convert.ToInt32(CBVidDoc.SelectedItem);
            Classi.GlobalPeremen.tegDocs = Convert.ToInt32(CBTegDoc.SelectedItem);
            Classi.GlobalPeremen.IzdOrganDocs = Convert.ToInt32(CBOrgenDoc.SelectedItem);
            Classi.GlobalPeremen.regionDocs = Convert.ToInt32(CBRegionDoc.SelectedItem);
            Classi.GlobalPeremen.statusDocs = Convert.ToInt32(CBStatusDoc.SelectedItem);
            Classi.GlobalPeremen.pravovayaBaza = Convert.ToInt32(CBPravovayaBaza.SelectedItem);

            UpdateServices();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateServices();
        }

        private void CBTegDoc_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBStatusDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnDobavlenie_Click(object sender, RoutedEventArgs e)
        {
            Classi.GlobalPeremen.dobRedDoc = 1;
            NavigationService.Navigate(new Stranici.DobavlenieRedaktirovanieDoc());
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

        private void BtnRedactirovanie_Click(object sender, RoutedEventArgs e)
        {
            Classi.GlobalPeremen.dobRedDoc = 2;
            var ddoc = (sender as Button).DataContext as Classi.DDocument;
            NavigationService.Navigate(new Stranici.DobavlenieRedaktirovanieDoc(ddoc));
        }

        private void CBPravovayaBaza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
