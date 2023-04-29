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
    /// Логика взаимодействия для PravovayaBazaRashirPoisk.xaml
    /// </summary>
    public partial class PravovayaBazaRashirPoisk : Page
    {
        public PravovayaBazaRashirPoisk()
        {
            InitializeComponent();

            CBVidDoc.ItemsSource = App.Context.DVids.ToList();
            CBTegDoc.ItemsSource = App.Context.DTegs.ToList();
            CBOrgenDoc.ItemsSource = App.Context.DIzdavOrgans.ToList();
            CBRegionDoc.ItemsSource = App.Context.DRegions.ToList();
            CBStatusDoc.ItemsSource = App.Context.DStatus.ToList();

            //CBTegDoc.IsEnabled = false;

            UpdateServices();
        }

        private void UpdateServices()
        {
            var docs = App.Context.DDocuments.ToList();
            var tegs = App.Context.DTegs;
            //var dtags = App.Context.DDocuments + App.Context.DTegs;
            //var sDocs = App.Context.StatusDocs.ToList();

            // Поиск по названию (регистронезависимый)
            /*docs = docs.Where(p => p.Nazvanie.ToLower().Contains(TBoxPoisk.Text.ToLower()) ||
                              p.KratOpisanie.ToLower().Contains(TBoxPoisk.Text.ToLower())).ToList();*/
            //docs = docs.Where(p => p.KratOpisanie.ToLower().Contains(TBoxPoisk.Text.ToLower())).ToList();

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
                //docs = docs.Where(p => p.idDocumenta.Equals(tags.Where(q => q.idTega.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString())))).ToList();
                //docs = docs.Where(p => p.DTegs.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString())) && docs.Where(p => p.idDocumenta.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString())).ToList();
                //var dt = docs.Where(p => p.idDocumenta) == tags.Where(p => p.idTega).ToList();
                /*var docTeg = tags.Where(p => p.idTega.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString()))
                    == docs.Where(p => p.idDocumenta.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString()));*/
                //docs += docTeg;
                //docs = (docs.Where(p => p.idDocumenta.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString())) == tags.Where(p => p.idTega.ToString().Equals(Classi.GlobalPeremen.tegDocs.ToString()))).ToList();
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

            LVPravovayaBaza.ItemsSource = docs;

            /* Боковое меню */
            var npa = App.Context.DNPAs.ToList();
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

        private void BtnFederaLaws_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 2;
            UpdateServices();
        }

        private void BtnPresidentialDecrees_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 3;
            UpdateServices();
        }

        private void BtnGovernmentDecrees_Click(object sender, RoutedEventArgs e)
        {
            Classi.Bazi.Vibrano = 4;
            UpdateServices();
        }

        private void BtnNormativeAct_Click(object sender, RoutedEventArgs e)
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
            //UpdateServices();
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
            var errorMessage = CheckErrors();
            if (errorMessage.Length > 0)
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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

                UpdateServices();
            }
        }

        private string CheckErrors()
        {
            var errorBuilder = new StringBuilder();

            if (TBNomer.Text != "")
            {
                int nDoc = 0;
                if (int.TryParse(TBNomer.Text, out nDoc) == false || nDoc <= 0)
                    errorBuilder.AppendLine("Номер документа должен быть положительным числом;");
            }

            if (errorBuilder.Length > 0)
                errorBuilder.Insert(0, "Устраните следующие ошибки:\n");

            return errorBuilder.ToString();
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

            Classi.GlobalPeremen.nomerDocs = TBNomer.Text;
            Classi.GlobalPeremen.NachData = TBDataNach.Text;
            Classi.GlobalPeremen.konData = TBDataKon.Text;
            Classi.GlobalPeremen.vidDocs = Convert.ToInt32(CBVidDoc.SelectedItem);
            Classi.GlobalPeremen.tegDocs = Convert.ToInt32(CBTegDoc.SelectedItem);
            Classi.GlobalPeremen.IzdOrganDocs = Convert.ToInt32(CBOrgenDoc.SelectedItem);
            Classi.GlobalPeremen.regionDocs = Convert.ToInt32(CBRegionDoc.SelectedItem);
            Classi.GlobalPeremen.statusDocs = Convert.ToInt32(CBStatusDoc.SelectedItem);

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
    }
}
