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
using TelecomNevaSvyaz.Views.Windows;

namespace TelecomNevaSvyaz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e) 
        {
            Application.Current.Shutdown();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbLogin.Text == "" && txbPassword.Text == "")
                {
                    throw new Exception("Заполните все поля");
                }
                else
                {
                    var currentUser = Data.tns.Employee.FirstOrDefault(item => item.Login == txbLogin.Text && item.Password == txbPassword.Text);
                    switch (currentUser.IDRole)
                    {
                        case 1:
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.ShowDialog();
                            break;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ошибка");
            }
        }
    }
}
