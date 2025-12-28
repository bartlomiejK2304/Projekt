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

namespace WPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            User User = new User();
            string login = LoginBox.Text;
            string haslo = PasswordBox.Text;

            bool istnieje = User.Users.Any(n => n.Login == login);

            if (istnieje)
            {
                MessageBox.Show("Login istnieje");
            }
            else
            {
                MessageBox.Show("Nie ma takiego loginu");
            }

        }
    }
}
