   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	   F BDataLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:DataLibrary;assembly=DataLibraryDataLibrary 6*       Test.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Test     5   	   =zz.clr-namespace:DataLibrary;assembly=DataLibrary     6*   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      "  DataLibrary.V1MainCollection   key_data  key_view_V1DataCollection �� Source �� Path  key_view_V1DataOnGrid!   Test.FirstElement_Converter  FirstElement_Converter/   )Test.DataCollection_coordinates_Converter ( $DataCollection_coordinates_Converter  key_details_DataTemplate �� Orientation �� 	Converter��%  &	        &	      &	 Y     &	 �     &	 �     &	 �     7    5   
   6   �� 5   
   -   5         5      �� $ all_elements�6f   �� 5   
   -   5         5      �� $ all_elements�6b     5   
   6'     5   
   65   �� 5   
   .R�5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��time:��6    �� 5      ��6    �� $ t�5      �� 5      $ 
Horizontal=�6   .+�5      �� ��6    �� 8   5      5      5      5      .��5      � -   5         �Name$ grid_collection��5       � RowDefinitions 5   
   �� 5      $
��113* �6   �� 5      $
��104* �6    � ColumnDefinitions 5!   
   �� 5"      $��1* �6   �� 5#      $��1* �6   �� 5$      $��1* �6   �� 5%      $��1* �6   .+�5'   
   �� -   5        $��ListBox_Main��5'      $��10,30,10,10q�6P   ��6&   �� $ all_elements�6P   o� 5(   
   $��0,0,10,0q�6   $	��Top=�6!   $��4��69   $��25��6M   .@�5)      m� $
��File��6   .@�5*      m� -   5        $	��New��5*      6(   m� 5+      -   5        $
��Open��5+      6)   m� 5,      -   5        $
��Save��5,      6)   5-      m� 5.      $
��Edit��6   .@�5/      m� -	   5        $��Add Defaults��5/      61   m� 50      -
   5        $"��Add Default V1DataCollection��50      6A   m� 51      -   5        $��Add Default V1DataOnGrid��51      6=   m� 52      -   5        $��Add Element from File��52      6:   m� 53      -   5        $��Remove��53      6+   54      55      �� 56   
   -   5        $��ListBox_DataCollection��56   7   $��1��6   $��10,30,10,10q�6"   ��6U   �� 	 �� Source#	 [ �� 57   
   -   5        $��ListBox_DataOnGrid��57   7   $��2��6   $��10,30,10,10q�6"   ��6Q   �� #	 [ �� 58   
   -   5        $��textBlock_MaxCount��58   R   $��3��6   $
��Left=�6$   $��	25,30,0,0q�6?   $
��Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6l   �� $ 	max_count�6�   �� 59   
   -   5        $��ListBox_details��59   D   $��1��6   $��1��6"   $��10,10,10,10q�6/   #��[ 6�   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6�   ��6[   ��  �� ElementName$ ListBox_DataCollection��$ SelectedItem.value�6�   � 5:   
   -   5        $��Grid_DataOnGrid��5:      $��
10,0,10,10q�6&   $��2��6:   $��1��6J   .+�5;      �� -   5        $��TextBlock_FirstElement��5;   c   $��2��6   $
��Left=�6(   $��	10,31,0,0q�6C   $��1��6V   $
��Wrap=�6�   $	��Top=�6�   ��6�   �� $ ListBox_DataOnGrid��$" SelectedItem.points_value[0]�6�   �� 5<      -   5        $��TextBlock_LastElement��5<   c   $��2��6   $
��Left=�6(   $��	10,73,0,0q�6C   $��1��6V   $
��Wrap=�6  $	��Top=�6  ��6�   �� $ ListBox_DataOnGrid��$ SelectedItem.points_value�# [ 6  �� 5=      $��2��6   $
��Left=�6(   $��	10,10,0,0q�6C   $��1��6V   $ ��First element V1DataOnGrid��6c   $
��Wrap=�6�   $	��Top=�6�   �� 5>      $��2��6   $
��Left=�6(   $��	10,52,0,0q�6C   $��1��6V   $��Last element V1DataOnGrid��6c   $
��Wrap=�6�   $	��Top=�6�   5@      5A      5B      