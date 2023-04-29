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
    /// <summary>
    /// Логика взаимодействия для IzdOrgani.xaml
    /// </summary>
    public partial class IzdOrgani : Page
    {
        public IzdOrgani()
        {
            InitializeComponent();

            UpdateServices();
        }

        private void UpdateServices()
        {
            var organ = App.Context.DIzdavOrgans.ToList();

            organ = organ.Where(p => p.NazvanieOrgana.ToLower().Contains(TBoxPoisk.Text.ToLower())).ToList();

            LVIzdOrgan.ItemsSource = organ;

        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }
    }
}
