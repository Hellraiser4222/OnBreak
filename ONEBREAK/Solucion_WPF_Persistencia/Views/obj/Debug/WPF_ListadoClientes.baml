   M S B A M L   `   `   `  ����@  <Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewsViews  5   	       Views.WPF_ListadoClientes   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ OnBreak Listado Clientes��5
   	   $	��500��6*   $	��900��67   
�������.��5      � .+�5   
   �� -   5         ��Name$ 
imgusuario��5      $��Resources/pngguru.com.png��6$   $
��Left=�6G   $��66��6b   $��	825,5,0,0q�6n   $	��Top=�6�   $��65��6�   �� 5   
   -   5         ��Name$ 
lblusuario��5      $��Raul Ramirez Perez��6$   $
��Left=�6A   $��
696,23,0,0q�6\   $	��Top=�6p   $	��109��6�   
���   �6�   �� 5   
   $
��Left=�6   $/��)Resources/logo_transparent_background.png��6+   $	��100��6^   $��	10,10,0,0q�6k   $	��Top=�6~   $	��100��6�   �� 5   
   -   5        $ lblOpcionesFiltrado��5      $#��Seleccione opción de filtro:��6-   
�������$
��Bold"�6f   $
��Left=�6x   $��
140,88,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��16(�6�   $	��219��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.197Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ cmbOpcionFiltro��5      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Seleccione opción��6,    �� SelectedIndex$ -1��6a   	   ClearTextButton	 . $
��Left=�6�   $��142,124,0,0q�6�   $	��Top=�6�   $	��215��6�   ���	#FF1190CB.@�5      �� $��Rut Cliente��6   �� 5      $��Tipo de Empresa��6   �� 5      $��Actividad de empresa��6   5       �� 5!   
   -   5        
 ��Name$
 	txtFiltro��5!      	 . $. (Escriba directamente sobre el control...��6S   $
��Left=�6�   $��23��6�   $��398,124,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��264��6  ���	#FF1190CB6+  &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ dtgListadoClientes��5"         AutoGenerateColumns .  ���	#FF1190CB$��2q�6d   $
��Left=�6x   $	��270��6�   $��
10,189,0,0q�6�   $	��Top=�6�   $	��872��6�   
�������   AlternatingRowBackground 5#      �� 5$         RowBackground 5&      �� 5'       J� OpacityMask 5)      �� 5*       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5+      �  � Color$ 	#FF1190CB��6#    � Offset$ 0Q�65   � 5,      $ White��6#   $ 1Q�61   5-      ��5/      �� 50      $ 0.5,1&�6&   $ 0.5,0&�67   .��51      � $ White��6#   $ 0Q�61   � 52      $ 	#FF1190CB��6#   $ 1Q�65   53         Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$	 Rut��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6Q      
Foreground �	#FF2525261  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *
RutCliente+6\     58      $ Nombre��6%   $	 150 6]    �	#FF252526 65   ��  �� Path$ NombreContacto�6i     59      $ 	Direccion��6%   $	 105 6]    �	#FF252526 68   �� $ RazonSocial�6i     5:      $
 Mail��6%   $	 105 6Y    �	#FF252526 63   �� $ MailContacto�6e     5;      $ Razon��6%   $	 105 6W    �	#FF252526 64   �� $ 	Direccion�6c     5<      $ Telefono��6%   $	 110 6Y    �	#FF252526 67   �� $ Telefono�6e     5=      $ Act.Empresa��6%   $	 100 6p    �	#FF252526 6:   �� $" ActividadEmpresa.Descripcion�6|     5>      $ Tipo Empresa��6%   $	 104 6l    �	#FF252526 6;   �� $ TipoEmpresa.Descripcion�6x   5@      �� 5A   
   -   5        $ lblLista��5A      $��Listado de Clientes��6"   $
��Left=�6@   $��
142,23,0,0q�6[   $	��Top=�6o   $	��413��6�   
�������$��36(�6�   �� 5B   
   -	   5         ��Name$ btnTransfer��5B      $��
Transferir��6&      AccentedSquareButtonStyle#��[  6<   $
��Left=�6o   $��707,123,0,0q�6�   $	��Top=�6�   $��98��6�   6�   5C      5D      