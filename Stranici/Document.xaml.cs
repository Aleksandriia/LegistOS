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
using System.Xml.Linq;

namespace LegistOS.Stranici
{
    /// <summary>
    /// Логика взаимодействия для Document.xaml
    /// </summary>
    public partial class Document : Page
    {
        //private Classi.DDocument DDocument = null;
        //DDocument dDocument = new DDocument();
        public Document()
        {
            InitializeComponent();

            //UpdateServices();
        }

        //Classi.user37_dbEntities db = new Classi.user37_dbEntities();

        public Document(Classi.DDocument document)
        {
            InitializeComponent();

            TBlNazvanieDoc.Text = document.Nazvanie;
            TBlNomerDoc.Text = document.Nomer;
            TBOpisanie.Text = document.Opisanie;

            if (document.Status == 1)
                TBlStatusDoc.Text = "Действующие";
            else if (document.Status == 2)
                TBlStatusDoc.Text = "Не вступившие в силу";
            else if (document.Status == 3)
                TBlStatusDoc.Text = "Утратившие силу";
            //TBlStatusDoc.Text = document.Status.ToString();
            /*var stat = App.Context.DStatus.ToString();
            stat = stat.Where(p => p.CompareTo(DDocument.Status == DStatu.NazvanieStatusa)).ToString();
            TBlStatusDoc.Text = stat;*/

            //TBlVidDoc.Text = document.VidDoc.ToString();
            if (document.VidDoc == 1)
                TBlVidDoc.Text = "Акт";
            else if (document.VidDoc == 2)
                TBlVidDoc.Text = "Генеральное соглашение";
            else if (document.VidDoc == 3)
                TBlVidDoc.Text = "Декларация";
            else if (document.VidDoc == 4)
                TBlVidDoc.Text = "Документ";
            else if (document.VidDoc == 5)
                TBlVidDoc.Text = "Дополнение";
            else if (document.VidDoc == 6)
                TBlVidDoc.Text = "Закон";
            else if (document.VidDoc == 7)
                TBlVidDoc.Text = "Кодекс";
            else if (document.VidDoc == 8)
                TBlVidDoc.Text = "Меморандум";
            else if (document.VidDoc == 9)
                TBlVidDoc.Text = "Номенклатура";
            else if (document.VidDoc == 10)
                TBlVidDoc.Text = "Поправка";
            else if (document.VidDoc == 11)
                TBlVidDoc.Text = "Постановление";
            else if (document.VidDoc == 12)
                TBlVidDoc.Text = "Приказ";
            else if (document.VidDoc == 13)
                TBlVidDoc.Text = "Регламент";

            //TBlTegDoc.Text = document.DTegs.ToString();

            //TBlPravBazaDoc.Text = document.PravovayaBaza.ToString();
            if (document.PravovayaBaza == 1)
                TBlPravBazaDoc.Text = "Федеральная база";
            else if (document.PravovayaBaza == 2)
                TBlPravBazaDoc.Text = "Региональная база";
            else if (document.PravovayaBaza == 3)
                TBlPravBazaDoc.Text = "Судебная практика";

            //TBlRegionDoc.Text = document.Region.ToString();
            if (document.Region == 1)
                TBlRegionDoc.Text = "РФ";
            else if (document.Region == 2)
                TBlRegionDoc.Text = "Ярославская область";

            //TBlIzdOrganDoc.Text = document.IzdavOrgan.ToString();
            if (document.IzdavOrgan == 1)
                TBlIzdOrganDoc.Text = "Администрация Президента РФ";
            else if (document.IzdavOrgan == 2)
                TBlIzdOrganDoc.Text = "Министерство внутренних дел РФ";
            else if (document.IzdavOrgan == 3)
                TBlIzdOrganDoc.Text = "Министерство здравоохранения РФ";
            else if (document.IzdavOrgan == 4)
                TBlIzdOrganDoc.Text = "Министерство иностранных дел РФ";
            else if (document.IzdavOrgan == 5)
                TBlIzdOrganDoc.Text = "Министерство обороны РФ";
            else if (document.IzdavOrgan == 6)
                TBlIzdOrganDoc.Text = "Министерство образования и науки РФ";
            else if (document.IzdavOrgan == 7)
                TBlIzdOrganDoc.Text = "Министерство финансов РФ";
            else if (document.IzdavOrgan == 8)
                TBlIzdOrganDoc.Text = "Министерство экономического развития РФ";
            else if (document.IzdavOrgan == 9)
                TBlIzdOrganDoc.Text = "Министерство юстиции РФ";
            else if (document.IzdavOrgan == 10)
                TBlIzdOrganDoc.Text = "Правительство РФ";
            else if (document.IzdavOrgan == 11)
                TBlIzdOrganDoc.Text = "Президент РФ";
            else if (document.IzdavOrgan == 12)
                TBlIzdOrganDoc.Text = "Управление делами Президента РФ";
            else if (document.IzdavOrgan == 13)
                TBlIzdOrganDoc.Text = "Федеральная антимонопольная служба";
            else if (document.IzdavOrgan == 14)
                TBlIzdOrganDoc.Text = "Федеральная служба по аккредитации";
            else if (document.IzdavOrgan == 15)
                TBlIzdOrganDoc.Text = "Федеральное казначейство";

            TBlDataNachDoc.Text = ((DateTime)document.DataNach).ToString("dd.MM.yyyy");

            if (document.DataKon == null)
                TBlDataKoncaDoc.Text = "--------";
            else if (document.DataKon != null)
                TBlDataKoncaDoc.Text = ((DateTime)document.DataKon).ToString("dd.MM.yyyy");

        }

        /*private void UpdateServices()
        {
            //var document = App.Context.DDocuments.ToList();

            //document = document.Where(p => p.idDocumenta == Classi.GlobalPeremen.IDdoc).ToList();

            //LVDocument.ItemsSource = document;
        }*/

        private void BtnNazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
