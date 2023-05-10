using LegistOS.Classi;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для DobavlenieRedaktirovanieDoc.xaml
    /// </summary>
    public partial class DobavlenieRedaktirovanieDoc : Page
    {
        private Classi.DDocument _currDocument = null;

        public DobavlenieRedaktirovanieDoc()
        {
            InitializeComponent();

            if (Classi.GlobalPeremen.dobRedDoc == 1)
            {
                TBlZagolovokDIDoc.Text = "Добавление документа";
            }
            else if (Classi.GlobalPeremen.dobRedDoc == 2)
            {
                TBlZagolovokDIDoc.Text = "Изменение документа";
            }

            CBIzdavOrgan.ItemsSource = App.Context.DIzdavOrgans.ToList();
            CBVid.ItemsSource = App.Context.DVids.ToList();
            CBPravBaza.ItemsSource = App.Context.DPravovayaBazas.ToList();
            CBStatus.ItemsSource = App.Context.DStatus.ToList();
            CBRegion.ItemsSource = App.Context.DRegions.ToList();
            CBNPA.ItemsSource = App.Context.DNPAs.ToList();
                        
            DPDataKonDoc.Text = "";
        }

        public DobavlenieRedaktirovanieDoc(Classi.DDocument document)
        {
            InitializeComponent();

            if (Classi.GlobalPeremen.dobRedDoc == 1)
            {
                TBlZagolovokDIDoc.Text = "Добавление документа";
            }
            else if (Classi.GlobalPeremen.dobRedDoc == 2)
            {
                TBlZagolovokDIDoc.Text = "Изменение документа";
            }

            CBIzdavOrgan.ItemsSource = App.Context.DIzdavOrgans.ToList();
            CBVid.ItemsSource = App.Context.DVids.ToList();
            CBPravBaza.ItemsSource = App.Context.DPravovayaBazas.ToList();
            CBStatus.ItemsSource = App.Context.DStatus.ToList();
            CBRegion.ItemsSource = App.Context.DRegions.ToList();
            CBNPA.ItemsSource = App.Context.DNPAs.ToList();

            _currDocument = document;

            TBNomerDoc.Text = _currDocument.Nomer;
            TBNazvanieDoc.Text = _currDocument.Nazvanie;
            DPDataNachDoc.SelectedDate = _currDocument.DataNach;
            if (_currDocument.DataKon == null)
                DPDataKonDoc.Text = "";
            else
            {
                DPDataKonDoc.SelectedDate = _currDocument.DataKon;
            }
            TBKratOpisanie.Text = _currDocument.KratOpisanie;
            TBOpisanie.Text = _currDocument.Opisanie;
            CBIzdavOrgan.Text = _currDocument.DIzdavOrgan.NazvanieOrgana;
            CBVid.Text = _currDocument.DVid.NazvanieVida;
            CBPravBaza.Text = _currDocument.DPravovayaBaza.NazvanieBazi;
            CBStatus.Text = _currDocument.DStatu.NazvanieStatusa;
            CBRegion.Text = _currDocument.DRegion.NazvanieRegiona;
            CBNPA.Text = _currDocument.DNPA.NazvanieNPA;
        }


        private void BtnSohranenie_Click(object sender, RoutedEventArgs e)
        {
            if (_currDocument == null)
            {
                var docum = new Classi.DDocument
                {
                    Nomer = TBNomerDoc.Text,
                    Nazvanie = TBNazvanieDoc.Text,
                    DataNach = DPDataNachDoc.SelectedDate,
                    DataKon = DPDataKonDoc.SelectedDate,
                    KratOpisanie = TBKratOpisanie.Text,
                    Opisanie = TBOpisanie.Text,
                    IzdavOrgan = CBIzdavOrgan.SelectedIndex + 1,
                    VidDoc = CBVid.SelectedIndex + 1,
                    PravovayaBaza = CBPravBaza.SelectedIndex + 1,
                    Status = CBStatus.SelectedIndex + 1,
                    Region = CBRegion.SelectedIndex + 1,
                    NPA = CBNPA.SelectedIndex + 1
                };

                App.Context.DDocuments.Add(docum);
                App.Context.SaveChanges();
                MessageBox.Show("Данные успешно внесены.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                //NavigationService.GoBack();
            }
            else
            {
                _currDocument.Nomer = TBNomerDoc.Text;
                _currDocument.Nazvanie = TBNazvanieDoc.Text;
                _currDocument.DataNach = DPDataNachDoc.SelectedDate;
                if (DPDataKonDoc != null)
                    _currDocument.DataKon = DPDataKonDoc.SelectedDate;
                else
                {
                    _currDocument.DataKon = null;
                }
                _currDocument.KratOpisanie = TBKratOpisanie.Text;
                _currDocument.Opisanie = TBOpisanie.Text;
                _currDocument.IzdavOrgan = CBIzdavOrgan.SelectedIndex + 1;
                _currDocument.VidDoc = CBVid.SelectedIndex + 1;
                _currDocument.PravovayaBaza = CBPravBaza.SelectedIndex + 1;
                _currDocument.Status = CBStatus.SelectedIndex + 1;
                _currDocument.Region = CBRegion.SelectedIndex + 1;
                _currDocument.NPA = CBNPA.SelectedIndex + 1;

                App.Context.SaveChanges();
                MessageBox.Show("Изменения успешно внесены.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            NavigationService.GoBack();
        }

        private void BtnNazad_Click(object sender, RoutedEventArgs e)
        {
            if (Classi.GlobalPeremen.dobRedDoc == 1)
            {
                if (TBNomerDoc.Text != null || TBNazvanieDoc.Text != null ||
                    TBKratOpisanie.Text != null || TBOpisanie.Text != null ||
                    CBIzdavOrgan.Text != null || CBVid.Text != null || 
                    CBPravBaza.Text != null || CBStatus.Text != null || 
                    CBRegion.Text != null || CBNPA.Text != null
                    /*CBIzdavOrgan.SelectedIndex != -1 || CBVid.SelectedIndex != -1 || CBPravBaza.SelectedIndex != -1 ||
                    CBStatus.SelectedIndex != -1 || CBRegion.SelectedIndex != -1 || CBNPA.SelectedIndex != -1 ||
                    CBIzdavOrgan.SelectedIndex != 0 || CBVid.SelectedIndex != 0 || CBPravBaza.SelectedIndex != 0 ||
                    CBStatus.SelectedIndex != 0 || CBRegion.SelectedIndex != 0 || CBNPA.SelectedIndex != 0*/)
                {
                    if (MessageBox.Show("Изменения не были внесены.\nВы действительно хотите выйти?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        NavigationService.GoBack();
                    }
                }
                else if (TBNomerDoc.Text == null && TBNazvanieDoc.Text == null &&
                        TBKratOpisanie.Text == null && TBOpisanie.Text == null &&
                        CBIzdavOrgan.Text == null && CBVid.Text == null &&
                        CBPravBaza.Text == null && CBStatus.Text == null &&
                        CBRegion.Text == null && CBNPA.Text == null) 
                { 
                    NavigationService.GoBack(); 
                }
            }
            else if (Classi.GlobalPeremen.dobRedDoc == 2)
            {
                if (MessageBox.Show("Изменения не были внесены.\nВы действительно хотите выйти?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    NavigationService.GoBack();
                }
            }
        }

        private void CBVid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBIzdavOrgan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBPravBaza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBNPA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
