   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       
CRM_Client   CRM_Client.View.GoodsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      -   5          N� Title$.  (Карточка товара/слуги��5      .��5	      � -   5        $��mainGrid��5	      $��Center=�6   $��Center=�68   $��	0,-50,0,0q�6S   {�.   J� Opacity$
 0.95Q�6x    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $4��.Добавление товара/услуги��6   $	��350��65      Gradient_Green#���   6A   
������ $��7q�6�   .��5      �� $��-5,-6,-5,-6q�6   ���#E2E5EA.+�5      � $��15q�6    � ColumnDefinitions 5      �� 5      �� 5      $	��180 �6+    5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   .+�5      �� $��0��6    $��0��6-   $	��5,0q�6=   $��Center=�6J   $"Вид товара/услуги: �� 5   -     Gradient_Red#��[ 61   .�6\   *6_   5      �� 5       -   5        $��cbTypeGoods��5       $��0��62   $��1��6?   $��3q�6O    �� DisplayMemberPath$
 Name��6Z    �� SelectedValuePath$ ID��6s    �� SelectedValue 6�   �� *ID_TypeGoods+�� 5"      $��1��6    $��0��6-   $	��5,0q�6=   $��Center=�6J   Название: �� 5#   $   #��[ 6(   .�6S   *6V   5$      �� 5%      $��1��64   $��1��6A   $��3q�6Q   ��6   �� *Name+6Q   �� 5'      $��2��6    $��0��6-   $	��5,0q�6=   $��Center=�6J   
Цена: �� 5(       #��[ 6$   .�6O   *6R   5)      �� 5*      $��2��65   $��1��6B   $��3q�6R   ��6   �� *Price+6R   �� 5,      $��3��6    $��0��6-   $	��5,0q�6=   $��Center=�6J   Количество: �� 5-   &   #��[ 6*   .�6U   *6X   5.      *   $MahApps.Metro.Controls.NumericUpDown  5/      $��3��6J   $��1��6W   $��3q�6g      TextAlignment$
 Left=�6r      Minimum$ 0Q�6�   	   Value	 6-   �� *
CountUnits+6�   50      51      52      �� 54   
   -   5        $��btnSeveGoods��54      $��1��6%   $	��100��62   $��7q�6>   $��Сохранить��6I   $��Right=�6]   #���   6y   
�������6�   56      57      