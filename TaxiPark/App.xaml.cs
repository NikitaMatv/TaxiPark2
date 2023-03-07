using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TaxiPark.Components;
namespace TaxiPark
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TaxiBDEntities DB = new TaxiBDEntities();
        public static Emplooy LoggedEmployee;
    }
}
