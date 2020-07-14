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
using MahApps.Metro.Controls.Dialogs;
using PersistenciaBD;
using Servicios;


namespace Views
{


    public partial class WPF_ListadoClientes : MetroWindow
    {

        ServicioCliente sc = new ServicioCliente();
        public WPF_ListadoClientes()
        {
            InitializeComponent();
            CargarListadoClientes();

        }

        private async void CargarListadoClientes()
        {
            try
            {
                dtgListadoClientes.ItemsSource = sc.GetEntities();
                dtgListadoClientes.Items.Refresh();
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", "Problemas de conexión con la base de datos\n" + ex.Message);
            }
        }

        private void FiltrarListado()
        {
            string filtro = txtFiltro.Text;
            int opcion = cmbOpcionFiltro.SelectedIndex;
            List<Cliente> cliente = new List<Cliente>();
            if (opcion == -1)
            {
                foreach (Cliente a in sc.GetEntities())
                {
                    if (a.RutCliente.ToString().Contains(filtro) || a.IdTipoEmpresa.ToString().Contains(filtro.ToLower()) || a.IdActividadEmpresa.ToString().Contains(filtro.ToLower()))
                    {
                        cliente.Add(a);
                    }
                }
            }
            else if (opcion == 0)
            {
                foreach (Cliente a in sc.GetEntities())
                {
                    if (a.RutCliente.ToString().Contains(filtro))
                    {
                        cliente.Add(a);
                    }
                }
            }
            else if (opcion == 1)
            {
                foreach (Cliente a in sc.GetEntities())
                {
                    if (a.IdTipoEmpresa.ToString().Contains(filtro.ToLower()))
                    {
                        cliente.Add(a);
                    }
                }
            }
            else if (opcion == 2)
            {
                foreach (Cliente a in sc.GetEntities())
                {
                    if (a.IdActividadEmpresa.ToString().Contains(filtro.ToLower()))
                    {
                        cliente.Add(a);
                    }
                }
            }
            dtgListadoClientes.ItemsSource = cliente;
            dtgListadoClientes.Items.Refresh();
        }



        private void TxtFiltro_TextChanged(object sender, TextChangedEventArgs e)
        {
            FiltrarListado();
        }

        private void CmbOpcionFiltro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FiltrarListado();
        }



        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CargarListadoClientes();

        }

        private void BtnTransfer_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = (Cliente)dtgListadoClientes.SelectedItem;
            string parent = this.Owner.Name;
            if (parent == "WPF_Clientes")
            {
                WPF_Clientes wc = (WPF_Clientes)this.Owner;
                wc.CargarDatosClienteExterno(cliente);
                this.Close();
            }
            else if (parent == "WPF_ListadoClientes")
            {
                WPF_Clientes wc = (WPF_Clientes)this.Owner;
                wc.CargarDatosClienteExterno(cliente);
                this.Close();
            }
            else if (parent == "WPFMenu")
            {
                WPF_Clientes wc = new WPF_Clientes();
                wc.Show();
                wc.CargarDatosClienteExterno(cliente);
                this.Close();
            }
        }

        
    }
}

