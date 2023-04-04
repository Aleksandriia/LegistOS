using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LegistOS
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Classi.user37_dbEntities Context
        { get; } = new Classi.user37_dbEntities();

        public static Classi.DPolzovatel dPolzovatel = null;
    }
}
