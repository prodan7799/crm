   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       
CRM_Client#   CRM_Client.View.DirectoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      -   5        .��5      � $��Center=�6   $��Center=�6(     J� Opacity$
  0.95Q�6C    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $"��Редактирование��6   $	��350��6+      Gradient_Cyan#���   67   
������ $��7q�6~   .��5      �� $��-5,-6,-5,-6q�6   ���#E2E5EA.+�5      &   System.Windows.Controls.DataGrid  -   5        $��dgMain��5      $��15q�6)      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q   $	��220��6a   $��15q�6n      CanUserDeleteRows .    CanUserResizeColumns .     SelectionMode$ Single=�6�      HeadersVisibility$
 None=�6�   $   HorizontalScrollBarVisibility$ Hidden=�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width$	
 290 6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Name+6F   5      5      5      )   #MahApps.Metro.Controls.ProgressRing  5   
   -   5        $��
prLoadData��5          IsActive . 62   �� 5   
   -   5        $��btnSeveType��5      $��1��6$   $	��100��61   $��7q�6=   $��Сохранить��6H   $��Right=�6\   #���   6x   
�������6�   �� 5   
   $��Добавление��6   $	��350��6'   $��2��63     Gradient_Lime#���  6@   
������ $��7q�6�   .��5      �� $��-5,-6,-5,-6q�6   ���#E2E5EA.+�5       � $��15q�6    � ColumnDefinitions 5!      �� 5"      �� 5#      $	��180 �6+   .+�5&      �� $��0��6    $"��Новое значение:��60   $	��5,0q�6G   $��Center=�6T   �� 5'      -   5        $��tbNewElement��5'      $��1��6H   $��3q�6X   ��62   �� *Name+6X   5(      5)      5*      �� 5,   
   -   5        $��btnAddNewType��5,      $��3��6&   $	��100��63   $��7q�6?   $��Добавить��6J   $��Right=�6]   #���  6y   
�������6�   5.      5/      