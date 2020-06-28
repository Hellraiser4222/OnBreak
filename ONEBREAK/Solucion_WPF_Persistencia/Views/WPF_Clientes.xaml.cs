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
    /// <summary>
    /// Lógica de interacción para WPF_Clientes.xaml
    /// </summary>
    public partial class WPF_Clientes : MetroWindow
    {
        ServicioCliente sc = new ServicioCliente();
        ServicioTipoEmpresa te = new ServicioTipoEmpresa();
        ServicioActividadEmpresa sac = new ServicioActividadEmpresa();
        public WPF_Clientes()
        {
            InitializeComponent();
            CargarListadoActividad();
            CargarListadoTipoEmpresa();
        }

        private async void CargarListadoActividad()
        {
            try
            {
                List<ActividadEmpresa> act_empresa = sac.GetEntities();
                cmbActividadEmpresa.ItemsSource = act_empresa;
                cmbActividadEmpresa.SelectedValuePath = "IdActividadEmpresa";
                cmbActividadEmpresa.DisplayMemberPath = "Descripcion";
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }

        }

        private async void CargarListadoTipoEmpresa()
        {
            try
            {
                List<TipoEmpresa> tipoEmpresa = te.GetEntities();
                cmbTipoEmpresa.ItemsSource =tipoEmpresa;
                cmbTipoEmpresa.SelectedValuePath = "IdTipoEmpresa";
                cmbTipoEmpresa.DisplayMemberPath = "Descripcion";
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }

        }

        public async void RegistrarCliente()
        {
            try
            {
                string rut;
                string nombre;
                string razon;
                string mail;
                string direccion;
                string telefono;
                int act_empresa;
                int tipo_empresa;

                if (txtrut.Text.Trim().Length > 0)
                {
                    rut = txtrut.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar un Rut válido");
                    return;
                }
                if (txtnombre.Text.Trim().Length > 0)
                {
                    nombre = txtnombre.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar un nombre válido");
                    return;
                }
                if(txtrazon.Text.Trim().Length>0)
                {
                    razon = txtrazon.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una Razon Social válida");
                    return;
                }
                if (txtmail.Text.Trim().Length > 0)
                {
                    mail = txtmail.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar un mail válido");
                    return;
                }
                if (txtdireccion.Text.Trim().Length > 0)
                {
                    direccion = txtdireccion.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una direccion válida");
                    return;
                }
                if (txttelefono.Text.Trim().Length > 0)
                {
                    telefono = txttelefono.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar un numero de telefono válido");
                    return;
                }
                if (cmbActividadEmpresa.SelectedIndex >-1)
                {
                    act_empresa = (int)cmbActividadEmpresa.SelectedValue;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una actividad de empresa válida");
                    return;
                }
                if (cmbTipoEmpresa.SelectedIndex >-1)
                {
                    tipo_empresa = (int)cmbTipoEmpresa.SelectedValue;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar un tipo de empresa válido");
                    return;
                }

                Cliente cliente = new Cliente
                {
                    RutCliente = rut,
                    NombreContacto = nombre,
                    RazonSocial = razon,
                    MailContacto = mail,
                    Direccion = direccion,
                    Telefono = telefono,
                    IdActividadEmpresa = act_empresa,
                    IdTipoEmpresa = tipo_empresa
                };
                sc.AddEntity(cliente);
                await this.ShowMessageAsync("Exito:", "Datos del autor registrados correctamente!!!", MessageDialogStyle.Affirmative);
                
            }
            catch (ArgumentException ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }

        }


        public async void ModificarCliente()
        {
            try
            {
                string rut = txtrut.Text;
                string nombre = txtnombre.Text;
                string razon = txtrazon.Text;
                string mail = txtmail.Text;
                string direccion = txtdireccion.Text;
                string telefono = txttelefono.Text;
                int act_empresa = (int)cmbActividadEmpresa.SelectedValue;
                int tipo_empresa = (int)cmbTipoEmpresa.SelectedValue;


                Cliente cliente = new Cliente
                {
                    RutCliente = rut,
                    NombreContacto = nombre,
                    RazonSocial = razon,
                    MailContacto = mail,
                    Direccion = direccion,
                    Telefono = telefono,
                    IdActividadEmpresa = act_empresa,
                    IdTipoEmpresa = tipo_empresa
                };
                sc.UpdateEntity(cliente);
                await this.ShowMessageAsync("Exito:", "Datos del autor modificados correctamente!!!", MessageDialogStyle.Affirmative);
                LimpiarControles();
            }
            catch (ArgumentException ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }
        }

        public async void EliminarCliente()
        {
            try
            {
                MessageDialogResult result = await this.ShowMessageAsync("Pregunta:", "Estas seguro que deseas eliminar al cliente indicado?", MessageDialogStyle.AffirmativeAndNegative);
                if (result == MessageDialogResult.Affirmative)
                {
                    string rut = txtbuscaRut.Text;
                    sc.DeleteEntity(rut);
                    await this.ShowMessageAsync("Exito:", "Datos del cliente eliminados!!!", MessageDialogStyle.Affirmative);
                    
                }
            }
            catch (ArgumentException ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }
            catch (FormatException)
            {
                await this.ShowMessageAsync("Error:", "Debes agregar un Rut para eliminar");
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", "Se ha producido un error desconocido.\n" + ex.Message);
            }
        }

        public async void BuscarDatosCliente()
        {
            try
            {
                Cliente cliente = sc.GetEntity(txtbuscaRut.Text);
                if (cliente != null)
                {
                    await this.ShowMessageAsync("Exito:", "Cliente encontrado con exito");
                    txtdireccion.Text = cliente.Direccion;
                    txtmail.Text = cliente.MailContacto;
                    txtnombre.Text = cliente.NombreContacto;
                    txtrazon.Text = cliente.RazonSocial;
                    txtrut.Text = cliente.RutCliente;
                    txttelefono.Text = cliente.Telefono;
                    cmbActividadEmpresa.SelectedValue = cliente.IdActividadEmpresa;
                    cmbTipoEmpresa.SelectedValue = cliente.IdTipoEmpresa;
                    
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debe ingresar un rut valido");
                }
               
            }
            catch(Exception ex)
            {
                await this.ShowMessageAsync("Error:", "No se ha podido encontrar al cliente." + ex.Message);
            }

        }

        public async void CargarDatosClienteExterno(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    txtdireccion.Text = cliente.Direccion;
                    txtmail.Text = cliente.MailContacto;
                    txtnombre.Text = cliente.NombreContacto;
                    txtrazon.Text = cliente.RazonSocial;
                    txtrut.Text = cliente.RutCliente;
                    txttelefono.Text = cliente.Telefono;
                    cmbActividadEmpresa.SelectedValue = cliente.IdActividadEmpresa;
                    cmbTipoEmpresa.SelectedValue = cliente.IdTipoEmpresa;
                }
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }
        }

        private void LimpiarControles()
        {
            CargarListadoActividad();
            CargarListadoTipoEmpresa();
            txtbuscaRut.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txtmail.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtrazon.Text = string.Empty;
            txtrut.Text = string.Empty;
            txttelefono.Text = string.Empty;
            cmbActividadEmpresa.SelectedIndex = -1;
            cmbTipoEmpresa.SelectedIndex = -1;
            
        }
        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            RegistrarCliente();
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarCliente();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarCliente();
        }

        private void wpf_clientes_activated(object sender, EventArgs e)
        {
            CargarListadoActividad();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            BuscarDatosCliente();
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarControles();
        }

        private void BtnMostarListado_Click(object sender, RoutedEventArgs e)
        {
            WPF_ListadoClientes wlc = new WPF_ListadoClientes();
            wlc.Owner = Window.GetWindow(this);
            wlc.Owner.Name = "WPF_ListadoClientes";
            wlc.Show();
        }
    }
}
