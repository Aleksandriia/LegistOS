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
using static System.Net.Mime.MediaTypeNames;

namespace LegistOS.Stranici
{
    /// <summary>
    /// Логика взаимодействия для DobavlenieDoc.xaml
    /// </summary>
    public partial class DobavlenieDoc : Page
    {
        public DobavlenieDoc()
        {
            InitializeComponent();
        }

        public DobavlenieDoc(Classi.DDocument document)
        {
            InitializeComponent();
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
    }
}
