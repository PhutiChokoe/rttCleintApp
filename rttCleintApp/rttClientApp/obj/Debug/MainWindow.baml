   M S B A M L   `   `   `  ����G  CrttClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:rttClientApprttClientApp  5   	       rttClientApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:rttClientApp     5   	     � Title$  
MainWindow��5   	   $��516.38��6   $��550.812��6,   .��5	      � $��
0,0,-83,16q�6   .+�5
   
   �� -   5         ��Name$ label��5
      $��Client Details��6   $
��Left=�68   $��	10,10,0,0q�6S   $	��Top=�6f    J� RenderTransformOrigin$ -0.377,-0.051&�6~   �� 5   
   -   5        $ label1��5      $
��Name��6    $
��Left=�6/   $��	16,41,0,0q�6J   $	��Top=�6]   �� 5   
   -   5        $ label1_Copy��5      $��Surname��6%   $
��Left=�67   $��	16,65,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ label1_Copy1��5      $��Gender��6&   $
��Left=�67   $��
278,66,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ label1_Copy2��5      $��	Id Number��6&   $
��Left=�6:   $��
278,41,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ label1_Copy5��5      $��Address Details��6&   $
��Left=�6@   $��
14,125,0,0q�6[   $	��Top=�6o   �� 5   
   -   5        $ label1_Copy6��5      $��Contact Details��6&   $
��Left=�6@   $��
16,320,0,0q�6[   $	��Top=�6o   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGrid��5      $
��Left=�6V   $��
15,267,0,0q�6q   $	��Top=�6�   $��53��6�   $	��501��6�   ��6%   �� *AddressList+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Street Address��6&   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *StreetAddressLine1+  5      $ Surburb��6%    66   �� *StreetAddressLine2+  5      $
 City��6%    63   �� *City+  5      $ Postal Code��6%    6:   �� *
Province+  5      $ Province��6%    67   �� *
PostalCode+5        5   
   -	   5        $ 	DataGrid1��5      $
��Left=�6W   $��
16,414,0,0q�6r   $	��Top=�6�   $��53��6�   $	��501��6�   ��6&   �� *ContactList+$ TwoWay=� 5        5      $
 Type��6&    64   �� *Type+  5      $ Number��6%    65   �� *Number+5       �� 5!   
   -
   5         ��Name$ textBox��5!      $
��Left=�6#   $��23��6>   $��
110,45,0,0q�6J   	 �� TextWrapping$
	 Wrap=�6^   $	��Top=�6�   $	��120��6�   ��6r   �� 
 �� Path$

 Name�6�   �� 5"   
   -   5        $ textBox_Copy��5"      $
��Left=�6(   $��23��6C   $��
110,68,0,0q�6O   $
	 Wrap=�6c   $	��Top=�6�   $	��120��6�   ��6w   �� $
 Surname�6�   �� 5#   
   -   5        $ textBox_Copy1��5#      $
��Left=�6)   $��23��6D   $��
396,70,0,0q�6P   $
	 Wrap=�6d   $	��Top=�6�   $	��120��6�   ��6x   �� $
 Gender�6�   �� 5$   
   -   5        $ textBox_Copy2��5$      $
��Left=�6)   $��23��6D   $��
396,45,0,0q�6P   $
	 Wrap=�6d   $	��Top=�6�   $	��120��6�   ��6x   �� $
 IdNumber�6�   �� 5%   
   -   5        $ label1_Copy3��5%      $��Street Address��6&   $
��Left=�6?   $��
16,156,0,0q�6Z   $	��Top=�6n   �� 5&   
   -   5        $ label1_Copy4��5&      $��Surburb��6&   $
��Left=�68   $��
16,180,0,0q�6S   $	��Top=�6g   �� 5'   
   -   5        $ textBox_Copy3��5'      $
��Left=�6)   $��23��6D   $��116,156,0,0q�6P   $
	 Wrap=�6e   $	��Top=�6�   $	��145��6�   ��6y   �� *Name+6�   �� 5(   
   -   5        $ textBox_Copy4��5(      $
��Left=�6)   $��23��6D   $��116,183,0,0q�6P   $
	 Wrap=�6e   $	��Top=�6�   $	��145��6�   ��6y   �� *	Surname+6�   �� 5)   
   -   5        $ label1_Copy7��5)      $
��City��6&   $
��Left=�65   $��
16,206,0,0q�6P   $	��Top=�6d   �� 5*   
   -   5        $ label1_Copy8��5*      $��Province��6&   $
��Left=�69   $��279,186,0,0q�6T   $	��Top=�6i   �� 5+   
   -   5        $ textBox_Copy5��5+      $
��Left=�6)   $��23��6D   $��117,209,0,0q�6P   $
	 Wrap=�6e   $	��Top=�6�   $	��144��6�   ��6y   �� *Name+6�   �� 5,   
   -   5        $ label1_Copy9��5,      $��Postal Code��6&   $
��Left=�6<   $��281,157,0,0q�6W   $	��Top=�6l   �� 5-   
   -   5        $ textBox_Copy7��5-      $
��Left=�6)   $��23��6D   $��373,157,0,0q�6P   $
	 Wrap=�6e   $	��Top=�6�   $	��143��6�   ��6y   �� *Name+6�   �� 5.   
   -   5         ��Name$ button��5.      $	��Add��6!   $
��Left=�6T   $��417,235,0,0q�6o   $	��Top=�6�   $��99��6�   $ 0.902,0.517&�6�   ��6/   �� *ButtonAddAddress+6�   �� 5/   
   -   5         ��Name$ comboBox��5/      $
��Left=�6I   $��
97,351,0,0q�6d   $	��Top=�6x   $	��145��6�   ��6%   �� *ContactType+6�   �� 50   
   -   5        $ label1_Copy10��50      $
��Type��6'   $
��Left=�66   $��
16,347,0,0q�6Q   $	��Top=�6e   �� 51   
   -   5        $ label1_Copy11��51      $��Number��6'   $
��Left=�68   $��292,348,0,0q�6S   $	��Top=�6h   �� 52   
   -   5        $ textBox_Copy8��52      $
��Left=�6)   $��23��6D   $��373,351,0,0q�6P   $
	 Wrap=�6e   $	��Top=�6�   $	��145��6�   ��6y   �� *	Surname+6�   �� 53   
   -   5        $ button_Copy��53      $	��Add��6&   $
��Left=�6Z   $��418,389,0,0q�6u   $	��Top=�6�   $��99��6�   $ 0.902,0.517&�6�   ��65   �� *ButtonAddContact+6�   �� 54   
   -   5        $ button_Copy1��54      $	��Add��6K   $
��Left=�6Y   $��
417,98,0,0q�6t   $	��Top=�6�   $��99��6�   $ 0.902,0.517&�6�   ��6'   �� *ButtonAddClient+6�   �� 55   
   -   5        $ 	comboBox1��55      $
��Left=�6G   $��373,190,0,0q�6b   $	��Top=�6w   $	��143��6�   ��6&   �� *
Province+6�   9� 56   
   -   5         9�Name$ panel1��56       $��0��6   $��Panel 1��60   $��-99,-140,99,140q�6A   .��57      ��  �� Orientation$ Vertical=�6   .+�58      �� $��10q�6   $��Panel1 Text Block��6(   �� 59      $��10q�6   $��Panel1 Text Block��6(   �� 5:      $��10q�6   $��Panel1 Text Block��6(   �� 5;      $��10q�6   $��Panel1 Text Block��6(   �� 5<      $��10q�6   $��Panel1 Text Block��6(   5=      5>      5A      5B      