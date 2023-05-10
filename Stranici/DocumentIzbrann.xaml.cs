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
    /// Логика взаимодействия для DocumentIzbrann.xaml
    /// </summary>
    public partial class DocumentIzbrann : Page
    {
        public DocumentIzbrann()
        {
            InitializeComponent();
        }

        public DocumentIzbrann(Classi.DDocument document)
        {
            InitializeComponent();

            //dIzbrannoe.idPolzovatelya = App.dPolzovatel.idPolzovatelya;

            if (Classi.GlobalPeremen.IDdoc == 0)
            {
                Classi.GlobalPeremen.IDdoc = document.idDocumenta;
            }


            TBlNazvanieDoc.Text = document.Nazvanie;
            TBlNomerDoc.Text = document.Nomer;
            TBOpisanie.Text = document.Opisanie;

            switch (document.Status)
            {
                case 1:
                    TBlStatusDoc.Text = "Действующие";
                    break;
                case 2:
                    TBlStatusDoc.Text = "Не вступившие в силу";
                    break;
                case 3:
                    TBlStatusDoc.Text = "Утратившие силу";
                    break;
            }

            switch (document.VidDoc)
            {
                case 1:
                    TBlVidDoc.Text = "Акт";
                    break;
                case 2:
                    TBlVidDoc.Text = "Генеральное соглашение";
                    break;
                case 3:
                    TBlVidDoc.Text = "Декларация";
                    break;
                case 4:
                    TBlVidDoc.Text = "Документ";
                    break;
                case 5:
                    TBlVidDoc.Text = "Дополнение";
                    break;
                case 6:
                    TBlVidDoc.Text = "Закон";
                    break;
                case 7:
                    TBlVidDoc.Text = "Кодекс";
                    break;
                case 8:
                    TBlVidDoc.Text = "Меморандум";
                    break;
                case 9:
                    TBlVidDoc.Text = "Номенклатура";
                    break;
                case 10:
                    TBlVidDoc.Text = "Поправка";
                    break;
                case 11:
                    TBlVidDoc.Text = "Постановление";
                    break;
                case 12:
                    TBlVidDoc.Text = "Приказ";
                    break;
                case 13:
                    TBlVidDoc.Text = "Регламент";
                    break;
            }

            //TBlTegDoc.Text = document.DTegs.ToString();

            switch (document.PravovayaBaza)
            {
                case 1:
                    TBlPravBazaDoc.Text = "Федеральная база";
                    break;
                case 2:
                    TBlPravBazaDoc.Text = "Региональная база";
                    break;
                case 3:
                    TBlPravBazaDoc.Text = "Судебная практика";
                    break;
            }

            switch (document.Region)
            {
                case 1:
                    TBlRegionDoc.Text = "РФ";
                    break;
                case 2:
                    TBlRegionDoc.Text = "Ярославская область";
                    break;
            }

            switch (document.IzdavOrgan)
            {
                case 1:
                    TBlIzdOrganDoc.Text = "Администрация Президента РФ";
                    break;
                case 2:
                    TBlIzdOrganDoc.Text = "Министерство внутренних дел РФ";
                    break;
                case 3:
                    TBlIzdOrganDoc.Text = "Министерство здравоохранения РФ";
                    break;
                case 4:
                    TBlIzdOrganDoc.Text = "Министерство иностранных дел РФ";
                    break;
                case 5:
                    TBlIzdOrganDoc.Text = "Министерство обороны РФ";
                    break;
                case 6:
                    TBlIzdOrganDoc.Text = "Министерство образования и науки РФ";
                    break;
                case 7:
                    TBlIzdOrganDoc.Text = "Министерство финансов РФ";
                    break;
                case 8:
                    TBlIzdOrganDoc.Text = "Министерство экономического развития РФ";
                    break;
                case 9:
                    TBlIzdOrganDoc.Text = "Министерство юстиции РФ";
                    break;
                case 10:
                    TBlIzdOrganDoc.Text = "Правительство РФ";
                    break;
                case 11:
                    TBlIzdOrganDoc.Text = "Президент РФ";
                    break;
                case 12:
                    TBlIzdOrganDoc.Text = "Управление делами Президента РФ";
                    break;
                case 13:
                    TBlIzdOrganDoc.Text = "Федеральная антимонопольная служба";
                    break;
                case 14:
                    TBlIzdOrganDoc.Text = "Федеральная служба по аккредитации";
                    break;
                case 15:
                    TBlIzdOrganDoc.Text = "Федеральное казначейство";
                    break;
            }

            TBlDataNachDoc.Text = ((DateTime)document.DataNach).ToString("dd.MM.yyyy");

            if (document.DataKon == null)
                TBlDataKoncaDoc.Text = "--------";
            else if (document.DataKon != null)
                TBlDataKoncaDoc.Text = ((DateTime)document.DataKon).ToString("dd.MM.yyyy");

        }

        private void BtnNazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
