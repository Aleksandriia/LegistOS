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
            TBDataNachDoc.Text = _currDocument.DataNach.ToString();
            TBDataKonDoc.Text = _currDocument.DataKon.ToString();
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
                    //DataNach = DateTime.Parse(TBDataNachDoc.Text),
                    //DataKon = DateTime.Parse(TBDataKonDoc.Text)
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
                //_currDocument.DataNach = DateTime.Parse(TBDataNachDoc.Text);
                //_currDocument.DataKon = DateTime.Parse(TBDataKonDoc.Text);
                /*_currDocument.DIzdavOrgan = TBPochta.Text;
                _currDocument.DVid = PBParol.Password;
                _currDocument.DPravovayaBaza = PBParol.Password;
                _currDocument.DStatu = PBParol.Password;
                _currDocument.DRegion = PBParol.Password;
                _currDocument.DNPA = PBParol.Password;*/

                App.Context.SaveChanges();
                MessageBox.Show("Изменения успешно внесены.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            NavigationService.GoBack();
        }

        private void BtnNazad_Click(object sender, RoutedEventArgs e)
        {
            if (TBNomerDoc.Text != null || TBNazvanieDoc.Text != null ||
                TBKratOpisanie.Text != null || TBOpisanie.Text != null ||
                CBIzdavOrgan.Text != null || CBVid.Text != null || CBPravBaza.Text != null ||
                CBStatus.Text != null || CBRegion.Text != null || CBNPA.Text != null)
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
