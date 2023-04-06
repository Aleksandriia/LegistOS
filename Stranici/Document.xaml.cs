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
    /// Логика взаимодействия для Document.xaml
    /// </summary>
    public partial class Document : Page
    {
        public Document()
        {
            InitializeComponent();

            UpdateServices();
        }

        public Document(Classi.DDocument document)
        {
            InitializeComponent();

            TBlNazvanieDoc.Text = document.Nazvanie;
            TBlNomerDoc.Text = document.Nomer;
            //if (Classi.GlobalPeremen.IDdoc == 0)
            //    MessageBox.Show("Нет");
            //else if (Classi.GlobalPeremen.IDdoc != 0)
            //    Classi.GlobalPeremen.IDdoc = document.idDocumenta;
            /* Classes.GlobalVariables.IDdoc = document.IdDocument;
             * TBlOpisanie.Text = document.Opisanie;*/
            UpdateServices();
        }

        private void UpdateServices()
        {
            var document = App.Context.DDocuments.ToList();

            //document = document.Where(p => p.idDocumenta == Classi.GlobalPeremen.IDdoc).ToList();

            LVDocument.ItemsSource = document;
        }

        private void BtnNazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
