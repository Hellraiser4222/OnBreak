   M S B A M L   `   `   `  ����@  <Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewsViews  5   	       Views.WPF_Contratos   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Views     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ OnBreak Contratos��5
   	   $��966.5��6#   $	��858��62   
�������.��5      �  J� RenderTransformOrigin$ 0.454,0.377&�6   $��0,0,0,2q�6/   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF1190CB��6    � Offset$ 1Q�61   � 5      $ White��6   $ 0.359Q�6-   5       � ColumnDefinitions 5   
   �� 5      $	��62* �6   �� 5      $	��23* �6   .+�5   
   �� $��Resources/pngguru.com.png��6   $
��Left=�63   $��66��6N   $��
155,11,0,0q�6Z   $	��Top=�6n   $��65��6�   $ 0.507,-0.114&�6�   $��1��6�   �� 5   
   $��Raul Ramirez Perez��6   $
��Left=�6-   $��	41,37,0,0q�6H   $	��Top=�6[   $	��109��6s   
���   �$ 0.5,0.5&�6�   $��1��6�   $��26��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.211Q�6&   T� 5      5      5!      �� 5"   
   $/��)Resources/logo_transparent_background.png��6   $
��Left=�6D   $	��639��6_   $��
82,169,0,0q�6l   $	��Top=�6�   $	��635��6�   $��2��6�   	 J� Opacity$		 0.5Q�6�   �� 5#   
   $
��Left=�6   $/��)Resources/logo_transparent_background.png��6+   $	��100��6^   $	��Top=�6k   $	��100��6�   $ 	0.38,0.39&�6�   �� 5$   
   -   5        
 ��Name$
 lblContrato��5$      $��NUEVO CONTRATO��6%   $
��Left=�6>   $��
129,33,0,0q�6Y   $	��Top=�6m   $	��317��6�   
�������$��36(�6�   $��58��6�   �� 5%   
   -   5        $
 lblNro��5%      $��N° de 
Contrato:��6    $
��Left=�6D   $��	7,553,0,0q�6_   $	��Top=�6r   
�������$��20(�6�   $��63��6�   $��92��6�   �� 5&   
   -   5        $
 lblHraTermino��5&      $��Hora de Termino:��6'   $
��Left=�6B   $��
10,471,0,0q�6]   $	��Top=�6q   ���	#FF686868$��20(�6�   $ 0.497,0.095&�6�   $��37��6�   $	��162��6�   �� 5'   
   -   5        $
 lblHraInicio��5'      $��Hora de Inicio:��6&   $
��Left=�6@   $��	8,402,0,0q�6[   $	��Top=�6n   ���	#FF686868$��20(�6�   $ 0.46,-0.041&�6�   $��37��6�   $	��138��6�   �� 5(   
   -   5        $
 lblTipoEvento��5(      $��Tipo Evento:��6'   $
��Left=�6>   $��	0,184,0,0q�6Y   $	��Top=�6l   
�������$��20(�6�   $	��122��6�   $��37��6�   �� 5)   
   -   5        $
 lblIDModalidad��5)      $��
Modalidad:��6(   $
��Left=�6=   $��	8,241,0,0q�6X   $	��Top=�6k   
�������$��20(�6�   $ 
0.45,0.365&�6�   $��37��6�   $	��109��6�   �� 5*   
   -   5        $
 lblRut��5*      $��Rut del
Cliente:��6    $
��Left=�6D   $��
24,119,0,0q�6_   $	��Top=�6s   
�������$��20(�6�   $��63��6�   $��75��6�   �� 5+   
   -   5        $
 
lblTermino��5+      $��Termino:��6$   $
��Left=�67   $��612,371,0,0q�6R   $	��Top=�6g   
���   �$��20(�6�   $ 5.588,5.797&�6�   $��2��6�   $��37��6�   $��85��6�   �� 5,   
   -	   5        $
 lblCreacion��5,      $��	Creacion:��6%   $
��Left=�69   $��398,371,0,0q�6T   $	��Top=�6i   
���   �$��20(�6�   $��37��6�   $��91��6�   �� 5-   
   -
   5        $
 lblAsistentes��5-      $��Cantidad de 
Asistentes:��6'   $
��Left=�6S   $��	1,283,0,0q�6n   $	��Top=�6�   
�������$��20(�6�   $ 0.463,0.762&�6�   $��63��6�   $	��122��6�   �� 5.   
   -   5        $
 lblPersonal��5.      $��	Personal:��6%   $
��Left=�69   $��	8,351,0,0q�6T   $	��Top=�6g   
�������$��20(�6�   $ 0.669,-0.514&�6�   $��37��6�   $��89��6�   �� 5/   
   -   5        $
 lblRealizado��5/      $��
Realizado:��6&   $
��Left=�6;   $��390,128,0,0q�6V   $	��Top=�6k   
�������$��20(�6�   $��37��6�   $��99��6�   �� 50   
   -   5        $
 lblValorContrato��50      $��Valor del Contrato:��6*   $
��Left=�6H   $��	1,686,0,0q�6c   $	��Top=�6v   
�������$��20(�6�   $��37��6�   $	��175��6�   �� 51   
   -   5        $
 lblObservaciones��51      $��Observaciones:��6*   $
��Left=�6C   $��390,170,0,0q�6^   $	��Top=�6s   
�������$��20(�6�   $��37��6�   $	��143��6�   �� 52   
   -   5         ��Name$ txtNroContrato��52       �� 	MaxLength$ 9��6*   $��Center=�68   $
��Left=�6[   $��30��6v   $��122,571,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��230��6�   ���	#FF1190CB �� 
IsReadOnly . 6�   �� 53   
   -   5        $ txtObservaciones��53      $	 120��6,   $��Center=�6<   *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton . $
��Left=�6�   $	��159��6�   $��390,207,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��405��6�   ���	#FF1190CB$��2��6  �� 54   
   -   5        $ txtPersonal��54      $ 9��6'   $��Center=�65    . $
��Left=�6�   $��30��6�   $��122,358,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��232��6�   ���	#FF1190CB6�   �� 55   
   -   5        $ txtValor��55      $ 12��6$   $��Center=�63   $
��Left=�6V   $��30��6q   $��176,687,0,0q�6}   $
 Wrap=�6�   $	��Top=�6�   $	��176��6�   ���	#FF1190CB . 6�   �� 56   
   -   5        $ txtCantAsistentes��56      $ 9��6-   $��Center=�6;    . $
��Left=�6�   $��30��6�   $��122,302,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��232��6�   ���	#FF1190CB6�   �� 57   
   -   5         ��Name$ cmbModalidad��57      $��122,243,265,655q�6)   ���	#FF1190CB
�������6Y   �� 58   
   -   5        $ cmbTipoEvento��58      $��122,186,265,712q�6*   ���	#FF1190CB
�������6n   �� 59   
   -   5        $ txtHraTermino��59      $ 5��6)      	Watermark$ HH:RR��67   $��Center=�6`    . $
��Left=�6�   $��30��6�   $��	8,508,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��208��6  ���	#FF1190CB6"  �� 5:   
   -   5        $ txtIHranicio��5:      $ 5��6(   $ HH:RR��66   $��Center=�6_    . $
��Left=�6�   $��30��6�   $��
10,438,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��206��6  ���	#FF1190CB6"  �� 5;   
   -   5        $
 lblContrato_Copy��5;      $��CARGAR CONTRATO��6*   $
��Left=�6D   $��
13,722,0,0q�6_   $	��Top=�6s   $	��354��6�   
�������$��36(�6�   $��58��6�   �� 5<   
   -   5         ��Name$ btnRegistrar��5<         AccentedSquareButtonStyle#��[  6'   $�� Registrar Contrato��6Z   $
��Left=�6x   $��379,774,0,0q�6�   $	��Top=�6�   $	��187��6�   $��54��6�   $��18(�6�   6�   �� 5=   
   -   5        $ btnModificar��5=      #��[  6'   $��Modificar Contrato��6Z   $
��Left=�6w   $��378,845,0,0q�6�   $	��Top=�6�   $	��188��6�   $��54��6�   $��16(�6�   �� 5>   
   -   5        $ txtbuscaRut��5>      $ 10��6'   $��Center=�66   $ Ingrese el Rut��6X    . $
��Left=�6�   $��37��6�   $��
13,785,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  $	��329��6  ���	#FF1190CB$��20(�6B  �� 5?   
   -   5        $ 	btnBuscar��5?      #��[  6$   $��Buscar��6W   $
��Left=�6h   $��
13,848,0,0q�6�   $	��Top=�6�   $	��135��6�   $��51��6�   �� 5@   
   -   5        $
 
lblListado��5@      $%��Mostrar Listado
   de Contratos��6$   $
��Left=�6R   $��606,768,0,0q�6m   $	��Top=�6�   $	��194��6�   
�������$��26(�6�   $��2��6�   $��79��6�   �� 5A   
   -   5        $ btnMostarListado��5A      #��[  6,   $��Mostrar��6_   $
��Left=�6q   $��
11,852,0,0q�6�   $	��Top=�6�   $	��135��6�   $��44��6�   $��20(�6�   $��1��6�   6�   �� 5B   
   
�������$��1q�6%   $
��Left=�69   $	��144��6T   $��590,768,0,0q�6a   $	��Top=�6v   $	��215��6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5C   
   -   5          Name$ 	dtpInicio��5C      $
��Left=�6(   $��398,404,0,0q�6C   $	��Top=�6X   ���	#FF1190CB$��30��6�   $	��187��6�   $��Segoe UI)�6�   $��16(�6�     5D   
   -    5        $ 
dtpTermino��5D      $
��Left=�6)   $��612,402,0,0q�6D   $	��Top=�6Y   $��2��6q   ���	#FF1190CB$��30��6�   $	��196��6�   $��16(�6�   �� 5E   
   -!   5        $ 
btnAceptar��5E      #��[  6%   $��Aceptar��6X   $
��Left=�6j   $��240,467,0,0q�6�   $	��Top=�6�   $	��127��6�   $��51��6�   $ 0.354,1.883&�6�   $��16(�6  �� 5F   
   -"   5        $ 
btnLimpiar��5F      #��[  6%   $��Nuevo��6X   $
��Left=�6h   $��379,688,0,0q�6�   $	��Top=�6�   $	��186��6�   $��59��6�   $ 0.354,1.883&�6�   $��20(�6  �� 5G   
   -#   5        $
 lblValorAsis��5G      $��Valor Personal:��6&   $
��Left=�6@   $��	1,653,0,0q�6[   $	��Top=�6n   
�������$��20(�6�   $��37��6�   $	��153��6�   �� 5H   
   -$   5        $
 lblValorPerso��5H      $��Valor Asistentes:��6'   $
��Left=�6C   $��	1,616,0,0q�6^   $	��Top=�6q   
�������$��20(�6�   $��37��6�   $	��153��6�   �� 5I   
   -%   5        $ txtValorPerso��5I      $ 12��6)   $��Center=�68   $
��Left=�6[   $��30��6v   $��159,653,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��193��6�   ���	#FF1190CB . 6�   �� 5J   
   -&   5        $ txtValorAsis��5J      $ 12��6(   $��Center=�67   $
��Left=�6Z   $��30��6u   $��159,616,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��193��6�   ���	#FF1190CB . 6�   	� 5K   
   -'   5         	�Name$ rdbSI��5K      $��SI��6%   $
��Left=�62   $��494,135,0,0q�6M   $	��Top=�6b   $��24��6z   $��61��6�   $ 0.568,0.312&�6�   
�������$��20(�6�   	� 5L   
   -(   5        $ rdbNO��5L      $��NO��6%   $
��Left=�62   $��560,135,0,0q�6M   $	��Top=�6b   $��24��6z   $��50��6�   $ 0.568,0.312&�6�   
�������$��16(�6�   �� 5M   
   -)   5        $ cmbRut��5M      $��122,134,265,764q�6#   ���	#FF1190CB
�������6S   5O      5P      