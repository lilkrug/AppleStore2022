   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:KursovoiProject2kurs.MVVM.ViewKursovoiProject2kurs.MVVM.View  5   	   /    )KursovoiProject2kurs.MVVM.View.UserWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:KursovoiProject2kurs.MVVM.View     5   	     � Title$  
UserWindow��5   	   $	��500��6   $	��950��6)    � WindowStartupLocation$ CenterScreen=�65    � AllowsTransparency$
 True��6Z    � WindowStyle$
 None=�6t    � 	Resources 5	         
UserCursor �� 
TargetType  btTemplate10 �� CornerRadius��%d  &	        &	 f     ��5
   
   RNE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\NormalSelect.cur��6t   �� 5   
   " ��6   .R�5      �� $ 25��6   ���#2c2f33���#2c2f33$��50��5   *   ._�5      �� $��20(�6!   $��Center=�6/   $��Center=�6L   $��Поддержка��6g   
�������6{   5      5      5      .��5      � ���#F5F5DC � Cursor# [  6     � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.8* �6   .+�5   
   �� -   5        	 ��Name$	 ViewCurrentOrders��5   #   $��1��6   ��6>   �� *AllCurrentOrders+
 �� SelectedItem
 6g   �� *SelectedOrder+ � ContextMenu 5      �� 5      .@�5      m� $��Отменить��6    m� Command 61   �� *CancelOrder+5       �� View 5      �� 5      .P�5       �� $��Order Id��6%    �� Width$	 115��67    �� DisplayMemberBinding 5!   -   ��  �� Path$ Id��� 5"      $��Image��6%    �� CellTemplate 5#      �� 5$      .R�5%   "   �� $��60��6W   $��60��6b   ��6(   �� $ good.NoteImage.Picture�6b   5&      5(      �� 5)      $
��Name��6%   $	 100��63    5*   -   �� $ 	good.Name��� 5+      $��Category��6%   $	 120��67    5,   -   �� $ good.Category��� 5-      $��Price��6%    5.   -   �� $ 
good.Price��� 5/      $��Country��6%   $	 115��66    50   -   �� $ good.Country��� 51      $��Description��6%   $	 135��6:    52   -   �� $ good.Description�54      56      �� 57   
   -   5        $��<��57      $	��Top=�6    $
��Left=�58      
�������$��40��5:      $��30��5;      ���#272537$
 Hand��5=   $   �� 5>   
   $^��XE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\free-icon-user-7182164.png��6   $	��Top=�6r   $��Center=�6�   $��0 30 0 0q�6�   �� 5?   
   $��Пользователь��6   $��	0 220 0 0q�6(   $��20(�6;   $��Center=�6I   �� 5@   
   $	��150��6+   $��40��67   ���#2c2f33$��0 30 0 0q�6X   $��Center=�6j   $��Center=�6�   $��20(�6�   
���������6   �� *Login+6�   �� 5A   
   $��Поддержка��6   $��	0 140 0 0q�6H   #��[ 6[   $��50��6�   $
 Hand��6�   ��6%   �� *OpenSupportWnd+6�   5B      5C      