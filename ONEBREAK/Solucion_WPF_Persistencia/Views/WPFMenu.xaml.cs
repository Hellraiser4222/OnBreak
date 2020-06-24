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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using PersistenciaBD;

namespace Views
{
    /// <summary>
    /// Lógica de interacción para WPFMenu.xaml
    /// </summary>
    public partial class WPFMenu : MetroWindow
    {
        public WPFMenu()
        {
            InitializeComponent();
        }

        private void TlAdministradorContratos_Click(object sender, RoutedEventArgs e)
        {
            WPF_Contratos contratos = new WPF_Contratos();
            
            contratos.ShowDialog();
            
        }

        private void TlAdministradorAutores_Click(object sender, RoutedEventArgs e)
        {
            WPF_Clientes clientes = new WPF_Clientes();
           
            clientes.ShowDialog();
        }

        private void TlListadoClientes_Click(object sender, RoutedEventArgs e)
        {
            WPF_ListadoClientes Lclientes = new WPF_ListadoClientes();
            Lclientes.Owner = Window.GetWindow(this);
            Lclientes.Owner.Name = "WPFMenu";
            Lclientes.ShowDialog();
        }

        private void TlListadoContratos_Click(object sender, RoutedEventArgs e)
        {
            WPF_ListadoContratos lcontratos = new WPF_ListadoContratos();
           
            lcontratos.ShowDialog();
        }
    }
}
