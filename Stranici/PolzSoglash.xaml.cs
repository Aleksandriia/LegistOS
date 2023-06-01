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
    /// Логика взаимодействия для PolzSoglash.xaml
    /// </summary>
    public partial class PolzSoglash : Page
    {
        public PolzSoglash()
        {
            InitializeComponent();

            TBPolzSogl.Text = Classi.PolzovatSoglash.textPolzSoglash;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TBPolzSogl.Text = Classi.PolzovatSoglash.textPolzSoglash;
        }
    }
}
