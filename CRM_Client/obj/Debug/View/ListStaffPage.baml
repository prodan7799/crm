   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       
CRM_Client#   CRM_Client.View.ListStaffPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      -   5          N� Title$)  #Список сотрудников��5      .��5	      �� $��Сотрудники��6   $	��650��6#   $��	0,-70,0,0q�6/    J� Opacity$
 0.95Q�6B   $��Center=�6Q   $��Center=�6l      Gradient_Violet#���   6�   
������ .��5
   
   � $��-5,-6,-5,-6q�6   ���#E2E5EA.+�5      &   System.Windows.Controls.DataGrid  -   5        $��dgStaff��5         AutoGenerateColumns .  $	��350��6B   $��15q�6O   $��15q�6[      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6z      CanUserDeleteRows .    CanUserResizeColumns .     SelectionMode$ Single=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Имя��6G   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   �� *	FirstName+6G     5      $	 Фамилия��6F   
 6)   �� *
LastName+6F     5      $	 Отчество��6H   
 6)   �� *
Patronymic+6H     5      $	 Должность��6M   
 6)   �� *PostPeople.Name+6M   5      )   #MahApps.Metro.Controls.ProgressRing  5      -   5        $��
prLoadData��5   $      IsActive . 66   5      5      5      