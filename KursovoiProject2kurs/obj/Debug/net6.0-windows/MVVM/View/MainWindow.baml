   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KursovoiProject2kursKursovoiProject2kurs  5   	   %    KursovoiProject2kurs.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:KursovoiProject2kurs     5   	   -   5        $��MainMyViewWnd��5	   	     � Title$  
MainWindow��5   	   $	��500��6   $	��950��6)   $��Visible=�65   $y�Visible=�6h    � WindowStyle$
 None=�6}    � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5
         
UserCursor �� 
TargetType  btTemplate5 �� CornerRadius  btTemplate6  btTemplate7  btTemplate8  btTemplate9��%/  &	        &	 f     &	 R    &	 8    &	     &	     ��5   
   RNE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\NormalSelect.cur��6t   �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��50��5   *   ._�5      �� $��20(�6!   $��Center=�6/   $��Center=�6L   $��Сортировка��6g   
���   �6|   5      5      �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��50��5   *   ._�5      �� $��20(�6!   $��Center=�6/   $��Center=�6L   $��Профиль��6g   
���   �6y   5      5      �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��50��5   *   ._�5      �� $��20(�6!   $��Center=�6/   $��Center=�6L   $��
Выход��6g   
���   �6w   5      5      �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��50��5    *   ._�5!      �� $��20(�6!   $��Center=�6/   $��Center=�6L   $%��Сброс фильтрации��6h   
���   �6�   5"      5#      �� 5$   
   " ��6   .R�5%      �� $ 25��6   ���#F5F5DC���#F5F5DC$��50��5&   *   ._�5'      �� $��20(�6!   $��Center=�6/   $��Center=�6L   $��
Поиск��6h   
���   �6x   5(      5)      5*      .��5+      � $	��500��6   $��Center=�6   ���#272537 � Cursor# [  6H    � ColumnDefinitions 5-   
   �� 5.      $
��0.2* �6   �� 5/      $
��0.8* �6   .+�51   
   �� $��1q�6   $��0��6&   $��0q�66   ._�52      �� $��0��6   .+�53      �� $��50��67   $��	0 50 0 15q�6C   #��[ 6V   ��6   �� *
SortGood+6V   �� 54      $��50��6;   #��[ 6G   $��0 0 0 15q�6o   ��6   �� *ResetFilters+6o   �� 55      $��50��6:   $��0 0 0 15q�6}   #��[ 6�   ��6   �� *OpenUserWnd+��6F   �� 	 �� ElementName$	 MainMyViewWnd��6�   �� 56      $��50��69   #��[ 6E   $��0 0 0 15q�6m   ��6   �� *
SearchGood+6m   �� 57      $	��180��58      $��40��59      $��Center=�5:      $
��Left=�5;      $��5 0 5 15q�5<      
�������
���������5=      �� *	IPhones+5?      �� 5B      -   5        $
��Exit��5B      $��
Выход��6%   $��50��6V   $��0 50 0 0q�6b   #��[ 6t   $
 Hand��5C   M   ��5B   5   �� *ExitMainWnd+��5C      �� $	 MainMyViewWnd��6M   5D      5E      �� 5F   
   -   5        
 ��Name$
 ViewAllGoods��5F   "   $��1��6   
���������68   �� *
AllGoods+ �� SelectedItem 5G      �� *SelectedGoods+ � ContextMenu 5H      �� 5I      .@�5J      m� $��Купить��6    m� Command 6/   �� *	BuyGood+5K      ��5M      �� 5N      .R�5O      �  � Orientation$ 
Horizontal=�6    $
��Left=�69   $	��Top=�6T   6n   5P      ��5R      �� 5S      .R�5T      �� $��5q�6!   .+�5U      �� $��18(�6$   ��62   ��  �� Path$
 Name��� 5V      ��6$   �� $ Category��� 5W      ��6$   �� $ Price��� 5X      ��6$   �� $ Country��� 5Y      ��6$   �� $ Description��� 5Z      $	��100��6J   $	��100��6V   ��6    �� $ NoteImage.Picture�6V   5[      5\      5^      5_      5a      