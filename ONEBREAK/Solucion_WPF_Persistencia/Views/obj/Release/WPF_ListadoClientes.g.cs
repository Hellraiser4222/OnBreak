﻿#pragma checksum "..\..\WPF_ListadoClientes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80AC84A2C6AF28B4B80150A7AFB6F68B709F9F67"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Views;


namespace Views {
    
    
    /// <summary>
    /// WPF_ListadoClientes
    /// </summary>
    public partial class WPF_ListadoClientes : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\WPF_ListadoClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgusuario;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WPF_ListadoClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblusuario;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WPF_ListadoClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOpcionesFiltrado;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WPF_ListadoClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbOpcionFiltro;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WPF_ListadoClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFiltro;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WPF_ListadoClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgListadoClientes;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WPF_ListadoClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLista;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Views;component/wpf_listadoclientes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WPF_ListadoClientes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgusuario = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.lblusuario = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblOpcionesFiltrado = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.cmbOpcionFiltro = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.txtFiltro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dtgListadoClientes = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\WPF_ListadoClientes.xaml"
            this.dtgListadoClientes.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DtgListadoClientes_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 31 "..\..\WPF_ListadoClientes.xaml"
            this.dtgListadoClientes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DtgListadoClientes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblLista = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

