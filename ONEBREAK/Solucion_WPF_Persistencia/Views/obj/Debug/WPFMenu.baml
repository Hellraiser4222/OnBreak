   M S B A M L   `   `   `  ����@  <Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewsViews  5   	       Views.WPFMenu   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Views     5   	     � Title$  OnBreak Menu��5	   	   $	��500��6   $	��900��6+   
������� � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,-44,-56q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF1190CB��6    � Offset$ 1Q�61   � 5      $ White��6   $ 0.274Q�6-   5       � ColumnDefinitions 5   
   �� 5      $
��117* �6   �� 5      $	��92* �6   .+�5   
   � -   5         �Name$ wpMenu��5      $��49,76,86,80q�6$    J� 	AllowDrop . $��2��6J   .+�5      �� $/��)Resources/logo_transparent_background.png��6   $	��172��6H   $	��293��6U   	 J� RenderTransformOrigin$	 0.5,0.5&�6a   z�5      V� 5      .~�5      �� �� 5      �� 5      
 �� Angle$
 -0.472Q�6*   T� 5       5!      5#      !  MahApps.Metro.Controls.Tile  5$      -   5          Name$ tlAdministradorClientes��5$         Title$ Administracion Clientes��6=   $��5,5,5,5q�5%      
����� �$	��170��5'      $	��453��5(      $��14(�6(   
���   �.��5)      �� $��Resources/clientes.png��6   $��Right=�68   $	��136��6U   $	��129��6b   $	 	0.5,0.465&�6n   5*        5,      -   5        $ tlAdministradorContratos��5,      $ Administracion Contratos��6>   $��5,5,5,5q�5-      
������$	��170��5/      $	��280��50      
���   �.��51      �� $��Resources/contratos.png��6   $	��126��6:   $	��116��6G   52        54      -   5        $ tlListadoClientes��54      $ Listado Clientes��67   $��5,5,5,5q�55      
����� �$	��170��57      $	��232��58      
���   �.��59      �� $��Resources/buscarCLI.png��6   $	��160��69   $	��197��6F   5:        5;      -   5        $ tlListadoContratos��5;      $ Listado Contratos��68   $��5,5,5,5q�5<      
������$	��170��5>      $	��217��5?      
���   �.��5@      �� $ ��Resources/pngocean.com.png��6   $	��140��6<   $	��145��6I   5A      5D      �� 5E   
   $��Label��6   $
��Left=�6    $��
229,10,0,0q�6;   $	��Top=�6O   $��2��6g   $	��325��6{   �� 5F   
   -   5         ��Name$ lblBienvenida��5F      $��BIENVENIDO A ONBREAK��6'   $
��Left=�6F   $��	49,10,0,0q�6a   $	��Top=�6t   $	��284��6�   $��47��6�   ���	#FF686868$��24(�6�   �� 5G   
   $��Resources/pngguru.com.png��6   $��1��63   $
��Left=�6C   $��66��6^   $��	286,5,0,0q�6j   $	��Top=�6}   $��65��6�   �� 5H   
   $��Raul Ramirez Perez��6   $��1��6-   $
��Left=�6=   $��
157,23,0,0q�6X   $	��Top=�6l   $	��109��6�   
���   �6�   5J      5M      