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
    
    public partial class WPF_Contratos : MetroWindow
    {
        ServicioContrato sco = new ServicioContrato();
        ServicioModalidadServicio sms = new ServicioModalidadServicio();
        ServicioTipoEvento ste = new ServicioTipoEvento();
        ServicioCliente scl = new ServicioCliente();
        TipoEvento te = new TipoEvento();
        ModalidadServicio ms = new ModalidadServicio();

        public WPF_Contratos()
        {
            InitializeComponent();
            CargarListadoTipoEvento();
            CargarListadoRutClientes();
        }


        private void BtnMostarListado_Click(object sender, RoutedEventArgs e)
        {
            WPF_ListadoContratos wlc = new WPF_ListadoContratos();
            wlc.Owner = Window.GetWindow(this);
            wlc.Owner.Name = "WPF_ListadoContratos";
            wlc.Show();
        }

        private async void CargarListadoTipoEvento()
        {
            try
            {
                List<TipoEvento> tipoEvento = ste.GetEntities();
                cmbTipoEvento.ItemsSource = tipoEvento;
                cmbTipoEvento.SelectedValuePath = "IdTipoEvento";
                cmbTipoEvento.DisplayMemberPath = "Descripcion";
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }

        }


        private async void CargarListadoRutClientes()
        {
            try
            {
                List<Cliente> clientes = scl.GetEntities();
                cmbRut.ItemsSource = clientes;
                cmbRut.SelectedValuePath = "RutCliente";
                cmbRut.DisplayMemberPath = "RutCliente";
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }

        }


        private async void RegistrarContrato()
        {
            try
            {
                string nrocontrato;
                string rut;
                int cant_asistentes;
                int personal;
                //char realizado;
                double valor_contrato;
                string observaciones;
                DateTime hra_inicio;
                DateTime hra_final;
                DateTime partida;
                DateTime llegada;
                string modalidad;
                int tipo_evento;

                if (txtNroContrato.Text.Trim().Length > 0)
                {
                    nrocontrato = txtNroContrato.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Numero de contrato no creado");
                    return;
                }
                if (cmbRut.SelectedIndex > -1)
                {
                    rut = (string)cmbRut.SelectedValue;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar un rut válido");
                    return;
                }
                if (txtCantAsistentes.Text.Trim().Length > 0)
                {
                    cant_asistentes = int.Parse(txtCantAsistentes.Text);
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una cantidad de asistentes válida");
                    return;
                }
                if (txtPersonal.Text.Trim().Length > 0)
                {
                    personal = int.Parse(txtPersonal.Text);
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una cantidad de personal válida");
                    return;
                }
                if (txtValor.Text.Trim().Length > 0)
                {
                    valor_contrato = double.Parse(txtValor.Text);
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Valor del contrato no generado");
                    return;
                }
                if (txtObservaciones.Text.Trim().Length > 0)
                {
                    observaciones = txtObservaciones.Text;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar alguna observacion");
                    return;
                }
                if (txtIHranicio.Text.Trim().Length > 0 && DateTime.Parse(txtIHranicio.Text).Minute <= 59)
                {
                    hra_inicio = DateTime.Parse(txtIHranicio.Text);
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una hora de inicio válida");
                    return;
                }
                if (txtHraTermino.Text.Trim().Length > 0 && DateTime.Parse(txtHraTermino.Text).Minute <= 59)
                {
                    hra_final = DateTime.Parse(txtHraTermino.Text);
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una hora de termino válida");
                    return;
                }
                if (dtpInicio.Text.Trim().Length > 0)
                {
                    partida = DateTime.Parse(dtpInicio.Text);
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una fecha válida");
                    return;
                }
                if (dtpTermino.Text.Trim().Length > 0)
                {
                    llegada = DateTime.Parse(dtpTermino.Text);
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una fecha válida");
                    return;
                }
                if (cmbModalidad.SelectedIndex > -1)
                {
                    modalidad = cmbModalidad.SelectedValuePath;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar una modalidad válida");
                    return;
                }
                if (cmbTipoEvento.SelectedIndex > -1)
                {
                    tipo_evento = (int)cmbTipoEvento.SelectedValue;
                }
                else
                {
                    await this.ShowMessageAsync("Error:", "Debes ingresar un tipo de evento válido");
                    return;
                }

                Contrato contrato = new Contrato
                {
                    Numero = nrocontrato,
                    RutCliente = rut,
                    Asistentes = cant_asistentes,
                    PersonalAdicional = personal,
                    //agregar realizado
                    ValorTotalContrato = valor_contrato,
                    Observaciones = observaciones,
                    FechaHoraInicio = hra_inicio,
                    FechaHoraTermino = hra_final,
                    Creacion = partida,
                    Termino = llegada,
                    IdModalidad = modalidad,
                    IdTipoEvento = tipo_evento,

                };
                sco.AddEntity(contrato);
                await this.ShowMessageAsync("Exito:", "Datos del autor registrados correctamente!!!", MessageDialogStyle.Affirmative);

            }
            catch (ArgumentException ex)
            {
                await this.ShowMessageAsync("Error:", ex.Message);
            }

        }
        private async void limpiarPantalla()
        {
            try
            {
                dtpInicio.Text = String.Empty;
                dtpTermino.Text = String.Empty;
                txtbuscaRut.Text = String.Empty;
                txtCantAsistentes.Text = String.Empty;
                cmbRut.Text = String.Empty;
                txtHraTermino.Text = String.Empty;
                txtIHranicio.Text = String.Empty;
                txtObservaciones.Text = String.Empty;
                txtPersonal.Text = String.Empty;
                cmbModalidad.Text = String.Empty;
                cmbTipoEvento.Text = String.Empty;
                txtValor.Text = String.Empty;
                txtNroContrato.Text = string.Empty;
                txtValorAsis.Text = string.Empty;
                txtValorPerso.Text = string.Empty;


            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error: ", ex.Message);
            }
        }

        private async void cargarAsistentes()
        {
            try
            {
                string SAsistentes = txtCantAsistentes.Text;
                var asistentes = Convert.ToInt32(SAsistentes);
                Int32 recargo;
                if ((asistentes >= 1) && (asistentes <= 20))
                {
                    //UF a 27.000
                    recargo = (3 * 27000);
                    var precioAsistentes = asistentes * recargo;
                    var totalAsistentes = Convert.ToString(precioAsistentes);
                    txtValorAsis.Text = totalAsistentes;
                }
                else if ((asistentes >= 21) && (asistentes <= 50))
                {
                    //UF a 27.000
                    recargo = (5 * 27000);
                    var PrecioAsistentes = asistentes * recargo;
                    var totalAsistentes = Convert.ToString(PrecioAsistentes);
                    txtValorAsis.Text = totalAsistentes;
                }


            }
            catch (Exception ex)
            {

                await this.ShowMessageAsync("Error al transformar datos...", ex.Message);
            }
        }

        private async void cargarPersonal()
        {
            ServicioModalidadServicio serv = new ServicioModalidadServicio();
            try
            {
                Int32 recargo;
                var personalBase = 10;
                var SumaPersonal = txtPersonal.Text;
                var Personal = Convert.ToInt32(SumaPersonal);
                if (Personal > 10)
                {
                    var recargoPersonal = Personal - personalBase;
                    if (recargoPersonal == 2)
                    {
                        //UF a 27000
                        recargo = 2 * 27000;
                        var ValorRecargo = recargoPersonal * recargo;
                        var valorRecargoAdicionales = Convert.ToString(ValorRecargo);
                        txtValorPerso.Text = valorRecargoAdicionales;
                    }
                    if (recargoPersonal == 3)
                    {
                        //UF a 27000
                        recargo = 3 * 27000;
                        int ValorRecargo = recargoPersonal * recargo;
                        var valorRecargoAdicionales = Convert.ToString(ValorRecargo);
                        txtValorPerso.Text = valorRecargoAdicionales;
                    }
                    if (recargoPersonal == 4)
                    {
                        recargo = (int)(3.5 * 27000);
                        int ValorRecargo = recargoPersonal * recargo;
                        var valorRecargoAdicionales = Convert.ToString(ValorRecargo);
                        txtValorPerso.Text = valorRecargoAdicionales;
                    }
                    if (recargoPersonal > 4)
                    {
                        recargo = (int)(3.5 * 27000) + (int)(2.5 * 27000);
                        int ValorRecargo = recargoPersonal * recargo;
                        var valorRecargoAdicionales = Convert.ToString(ValorRecargo);
                        txtValorPerso.Text = valorRecargoAdicionales;
                    }

                }
                else if (Personal < 10)
                {
                    txtValorPerso.Text = "0";
                }

            }
            catch (Exception ex)
            {

                await this.ShowMessageAsync("Error al ingresar personal...", ex.Message);
            }
        }

        private async void CargaMontoFinal()
        {
            try
            {
                int asistentes, personal;
                asistentes = int.Parse(txtValorAsis.Text);
                personal = int.Parse(txtValorPerso.Text);
                int coste = asistentes + personal;
                txtValor.Text = coste.ToString();

            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error: ", ex.Message);
            }
        }


        private async void ModificarContrato()
        {
            try
            {
                DateTime partida = DateTime.Parse(dtpInicio.Text);
                DateTime llegada = DateTime.Parse(dtpTermino.Text);
                int cant_asistentes = int.Parse(txtCantAsistentes.Text);
                string rut = cmbRut.Text;
                DateTime hra_final = DateTime.Parse(txtHraTermino.Text);
                DateTime hra_inicio = DateTime.Parse(txtIHranicio.Text);
                string observaciones = txtObservaciones.Text;
                int personal = int.Parse(txtPersonal.Text);
                string modalidad = cmbModalidad.Text;
                int tipo_evento = int.Parse(cmbTipoEvento.Text);
                string nrocontrato = txtNroContrato.Text;
                double valor_contrato = double.Parse(txtValor.Text);



                Contrato contrato = new Contrato()
                {

                    Numero = nrocontrato,
                    RutCliente = rut,
                    Asistentes = cant_asistentes,
                    PersonalAdicional = personal,
                    //agregar realizado
                    ValorTotalContrato = valor_contrato,
                    Observaciones = observaciones,
                    FechaHoraInicio = hra_inicio,
                    FechaHoraTermino = hra_final,
                    Creacion = partida,
                    Termino = llegada,
                    IdModalidad = modalidad,
                    IdTipoEvento = tipo_evento,
                };
                sco.UpdateEntity(contrato);
                await this.ShowMessageAsync("Exito:", "Datos del autor modificados correctamente!!!", MessageDialogStyle.Affirmative);

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

        private async void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtIHranicio.Text.Trim().Length > 0 && DateTime.Parse(txtIHranicio.Text).Minute <= 59 && DateTime.Parse(txtHraTermino.Text).Minute <= 59 && DateTime.Parse(txtIHranicio.Text).Hour <= 23 && DateTime.Parse(txtHraTermino.Text).Hour <= 23)
                {
                    RegistrarContrato();
                }

            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error: ", ex.Message);
            }
            RegistrarContrato();
        }

        private async void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtpInicio.SelectedDate != null && DateTime.Parse(txtIHranicio.Text).Minute <= 59 && DateTime.Parse(txtIHranicio.Text).Hour <= 23)
                {
                    DateTime fecha = dtpInicio.SelectedDate.Value;
                    DateTime hora = DateTime.Parse(txtIHranicio.Text);
                    txtNroContrato.Text = fecha.ToString("yyyyMMdd") + hora.ToString("HHmm");
                    cargarPersonal();
                    cargarAsistentes();
                    CargaMontoFinal();
                }
                else
                {
                    await this.ShowMessageAsync("Error: ", "Debe ingresar una fecha valida.");
                }
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error: ", ex.Message);
            }

        }


        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarPantalla();
        }

        private void CmbTipoEvento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbModalidad.ItemsSource = new ServicioModalidadServicio().ListadoModalidad((int)cmbTipoEvento.SelectedValue);
            cmbModalidad.SelectedValuePath = "IdModalidad";
            cmbModalidad.DisplayMemberPath = "Nombre";

        }
    }
}
