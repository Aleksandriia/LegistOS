﻿using System;
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
    public partial class Pomosh : Page
    {
        public Pomosh()
        {
            InitializeComponent();

            FramePomosh.Navigate(new Stranici.Voprosi());
        }

        private void BtnVoprosi_Click(object sender, RoutedEventArgs e)
        {
            FramePomosh.Navigate(new Stranici.Voprosi());
        }

        private void BtnPolzSogl_Click(object sender, RoutedEventArgs e)
        {            
            FramePomosh.Navigate(new Stranici.PolzSoglash());
        }

        private void BtnObrPersDan_Click(object sender, RoutedEventArgs e)
        {
            FramePomosh.Navigate(new Stranici.ObrPersonDan());
        }
    }
}
