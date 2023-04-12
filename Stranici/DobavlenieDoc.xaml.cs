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
    }
}
