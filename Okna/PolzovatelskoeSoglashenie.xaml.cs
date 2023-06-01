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
using System.Windows.Shapes;

namespace LegistOS.Okna
{
    public partial class PolzovatelskoeSoglashenie : Window
    {
        public PolzovatelskoeSoglashenie()
        {
            InitializeComponent();
        }

        private void BtnSoglObrPersonDann_Click(object sender, RoutedEventArgs e)
        {
            FUrSoglDoc.Navigate(new Stranici.ObrabotkaPersonalDannih());
        }

        private void BtnPolzovatelSoglashen_Click(object sender, RoutedEventArgs e)
        {
            FUrSoglDoc.Navigate(new Stranici.PolzovatelskoeSoglashenie());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FUrSoglDoc.Navigate(new Stranici.ObrabotkaPersonalDannih());
        }
    }
}
