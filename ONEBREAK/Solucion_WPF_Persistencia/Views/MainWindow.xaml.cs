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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Views
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>

    public partial class MainWindow : MetroWindow
    {
        string username = "admin";
        string password = "123";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ValidarIngreso();
        }

        private async void ValidarIngreso()
        {
            if (txtUserName.Text.Equals(username) && psbPass.Password.Equals(password))
            {
                WPFMenu mnu = new WPFMenu();
                this.Close();
                mnu.ShowDialog();
            }
            else
            {
                await this.ShowMessageAsync("Error", "Nombre usuario y/o contraseña inválidos");
            }
        }

        private void psbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ValidarIngreso();
            }
        }
    }

}
