   M S B A M L   `   `   `  ����@  <Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewsViews  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   
   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   
       Views.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Views     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   
   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
   
     � WindowStartupLocation$  CenterScreen=�5       � Title$ OnBreak��5   	   $��Center=�6   $	��Top=�66   $��503.699��6N   $��353.222��6_   
�������.��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FF1190CB��6    � Offset$ 1Q�61   � 5      $ White��6   $ 0.341Q�6-   5      .+�5   
   �� -   5         ��Name$ imgLogin��5      $/��)Resources/logo_transparent_background.png��6"   $
��Left=�6U   $	��233��6p   $��	62,32,0,0q�6}   $	��Top=�6�   $	��250��6�   �� 5   
   -   5         ��Name$ txtUserName��5      $��admin��6'   *  $MahApps.Metro.Controls.TextBoxHelper	   	Watermark$	 Nombre usuario��64   
   ClearTextButton
 . $��20(�6�   $��Center=�6�   $��Center=�6�   $
��Left=�6�   $��40��6  $��
50,270,0,0q�6   �� TextWrapping$
 Wrap=�6#  $	��Top=�67  $	��250��6O  ���	#FF00C5FF6[  G� 5   
   -   5         G�Name$ psbPass��5       G� Password$	 123��6'   $��Center=�5      $	 Contraseña��5      
 .  "  MetroButtonRevealedPasswordBox#��[  5      $��Center=�5      $
��Left=�5      $��
50,333,0,0q�5      $	��Top=�5       $	��250��5!      $��40��5"      $��20(�5#      ���	#FF00C5FF6>   �� 5$   
   -   5         ��Name$ btnLogin��5$      $��Login��6#     AccentedSquareButtonStyle#��[ 63   $
��Left=�6g   $��110,398,0,0q�6�   $	��Top=�6�   $	��130��6�   $��40��6�   6�   5&      5(      