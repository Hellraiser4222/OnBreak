﻿#pragma checksum "..\..\WPFMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5AA54F8110495B6AB93E57DF11AE646B7D5CBA89"
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
    /// WPFMenu
    /// </summary>
    public partial class WPFMenu : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\WPFMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel wpMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WPFMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile tlAdministradorClientes;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\WPFMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile tlAdministradorContratos;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\WPFMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile tlListadoClientes;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WPFMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile tlListadoContratos;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\WPFMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBienvenida;
        
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
            System.Uri resourceLocater = new System.Uri("/Views;component/wpfmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WPFMenu.xaml"
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
            this.wpMenu = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 2:
            this.tlAdministradorClientes = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 33 "..\..\WPFMenu.xaml"
            this.tlAdministradorClientes.Click += new System.Windows.RoutedEventHandler(this.TlAdministradorAutores_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tlAdministradorContratos = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 41 "..\..\WPFMenu.xaml"
            this.tlAdministradorContratos.Click += new System.Windows.RoutedEventHandler(this.TlAdministradorContratos_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tlListadoClientes = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 49 "..\..\WPFMenu.xaml"
            this.tlListadoClientes.Click += new System.Windows.RoutedEventHandler(this.TlListadoClientes_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tlListadoContratos = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 56 "..\..\WPFMenu.xaml"
            this.tlListadoContratos.Click += new System.Windows.RoutedEventHandler(this.TlListadoContratos_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblBienvenida = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

