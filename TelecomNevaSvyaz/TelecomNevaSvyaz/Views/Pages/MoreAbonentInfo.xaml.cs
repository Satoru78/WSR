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
    /// Логика взаимодействия для MoreAbonentInfo.xaml
    /// </summary>
    public partial class MoreAbonentInfo : Page
    {
        public Gender Gender { get; set; }
        public TypeOfDogovor TypeOfDogovor { get; set; }
        public AbonentEqupment AbonentEqupment { get; set; }
        public Abonents Abonents { get; set; }
        public List<Abonents> Abonentss { get; set; }
        public MoreAbonentInfo(Abonents abonents)
        {
            InitializeComponent();
            Abonents = abonents;
            this.DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Abonentss = Data.tns.Abonents.ToList();
            AbonentMoreData.ItemsSource = Abonentss;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
