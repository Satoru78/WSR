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
    /// Логика взаимодействия для UserSupport.xaml
    /// </summary>
    public partial class UserSupport : Page
    {
        public Request Request { get; set; }
        public Status Status { get; set; }
      public List<Request> Requests { get; set; }
        public UserSupport(Request request)
        {
            InitializeComponent();
            Request = request;
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AbonentData(new Model.Abonents()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Requests = Data.tns.Request.ToList();
            RequestDataGrid.ItemsSource = Requests;
        }

       
    }
}
