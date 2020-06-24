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

namespace Views
{
    /// <summary>
    /// Lógica de interacción para WPF_Contratos.xaml
    /// </summary>
    public partial class WPF_Contratos : MetroWindow
    {
        public WPF_Contratos()
        {
            InitializeComponent();
        }

        private void BtnMostarListado_Click(object sender, RoutedEventArgs e)
        {
            WPF_ListadoContratos wlc = new WPF_ListadoContratos();
            wlc.Owner = Window.GetWindow(this);
            wlc.Owner.Name = "WPF_ListadoContratos";
            wlc.Show();
        }
    }
}
