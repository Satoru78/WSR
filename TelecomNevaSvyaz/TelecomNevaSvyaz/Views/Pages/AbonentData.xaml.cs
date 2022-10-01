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
using TelecomNevaSvyaz.Context;
using TelecomNevaSvyaz.Model;

namespace TelecomNevaSvyaz.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AbonentData.xaml
    /// </summary>
    public partial class AbonentData : Page
    {
        public Abonents Abonents { get; set; }
        public List<Abonents> Abonentss { get; set; }
        public AbonentData(Abonents abonents)
        {
            InitializeComponent();
            Abonents = abonents;
            this.DataContext = this;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Abonentss = Data.tns.Abonents.ToList();
            AbonentDataGrid.ItemsSource = Abonentss;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserSupport(new Model.Request()));
        }

        private void AbonentInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreAbonentInfo(new Model.Abonents()));
        }
    }
}
