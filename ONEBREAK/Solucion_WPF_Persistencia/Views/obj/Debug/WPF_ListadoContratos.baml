   M S B A M L   `   `   `  ����@  <Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewsViews  5   	        Views.WPF_ListadoContratos   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Views     5   	     � Title$  OnBreak Listado Contratos��5	   	   $	��500��6+   $	��900��68   
�������.��5      � .+�5   
   �� $
��Left=�6   $/��)Resources/logo_transparent_background.png��6+   $	��100��6^   $	��Top=�6k   $	��100��6�   �� 5   
   -   5         ��Name$ 
imgusuario��5      $��Resources/pngguru.com.png��6$   $
��Left=�6G   $��66��6b   $��	825,5,0,0q�6n   $	��Top=�6�   $��65��6�   �� 5   
   -   5         ��Name$ 
lblusuario��5      $��Raul Ramirez Perez��6$   $
��Left=�6A   $��
696,23,0,0q�6\   $	��Top=�6p   $	��109��6�   
���   �6�   �� 5   
   -   5        $ lblLista��5      $��Listado de Contratos��6"   $
��Left=�6A   $	��Top=�6\   $	��413��6t   
�������$��36(�6�   $��
105,10,0,0q�6�   �� 5   
   -   5        $ lblOpcionesFiltrado��5      $#��Seleccione opción de filtro:��6-   
�������$
��Bold"�6f   $
��Left=�6x   $��
110,66,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��16(�6�   $	��219��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.197Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ cmbOpcionFiltro��5      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Seleccione opción��6,    �� SelectedIndex$ -1��6a      ClearTextButton . $
��Left=�6�   $��
115,94,0,0q�6�   $	��Top=�6�   $	��215��6�   ���	#FF1190CB$��26��6  .@�5      �� $��Nro de Contrato��6   �� 5      $��Rut Cliente��6   �� 5      $��Tipo de Evento��6   �� 5      $��Modalidad de Evento��6   5      �� 5    
   -   5        	 ��Name$	 	txtFiltro��5        . $. (Escriba directamente sobre el control...��6S   $
��Left=�6�   $��23��6�   $��
383,94,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��264��6  ���	#FF1190CB6  &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ dtgListadoClientes��5!         AutoGenerateColumns .  ���	#FF1190CB$��2q�6d   $
��Left=�6x   $	��319��6�   $��
10,140,0,0q�6�   $	��Top=�6�   $	��872��6�   
�������   AreRowDetailsFrozen .    RowBackground 5"      �� 5#         AlternatingRowBackground 5%      �� 5&       J� OpacityMask 5(      �� 5)       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5*      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5+      $ White��6#   $ 1Q�61   5,      ��5.      �� 5/      $ 0.5,1&�6&   $ 0.5,0&�67   .��50      � $ White��6#   $ 0Q�61   � 51      $ 	#FF1190CB��6#   $ 1Q�65   52         Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Numero de Contrato��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 218 6`      
Foreground �	#FF2525261  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *
RutCliente+6l     57      $ Rut del Cliente��6%   $	 218 6a    �	#FF252526 6>   �� *NombreContacto+6m     58      $ Tipo de Evento��6%   $	 218 6]    �	#FF252526 6=   �� *RazonSocial+6i     59      $ Modalidad de Evento��6%   $	 218 6c    �	#FF252526 6B   �� *MailContacto+6o   5;      5>      5?      