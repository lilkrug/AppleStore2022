   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:KursovoiProject2kurs.MVVM.ViewKursovoiProject2kurs.MVVM.View  5   	   +    %KursovoiProject2kurs.MVVM.View.IPhone   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:KursovoiProject2kurs.MVVM.View     5   	   -   5        $��AddGoodsWnd��5	   	     � Title$  IPhone��5   	   $	��600��6   $
��1000��6%    � WindowStartupLocation$ CenterScreen=�62    � AllowsTransparency$
 True��6X    � WindowStyle$
 None=�6r    � 	Resources 5
         
UserCursor �� 
TargetType  
btTemplate �� CornerRadius  OutPutGoods  btTemplate1  ChangeGoods  btTemplate2  AddGoods��%  &	        &	 f     &	 >    &	     ��5   
   RNE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\NormalSelect.cur��6t   �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��70��5   *   ._�5      �� $��20(�6!   $��Center=�6/   $��Center=�6L   #���  6g   
���   �6�   5      5      �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��70��5   *   ._�5      �� $��20(�6!   $��Center=�6/   $��Center=�6L   #���  6g   
���   �6�   5      5      �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��70��5   *   ._�5      �� $��20(�6!   $��Center=�6/   $��Center=�6L   #���  6g   
���   �6�   5      5      5      .��5       �  � Cursor$
 Hand��6   ��5!   
   �� 5"       �� ImageSource$S ME:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\IPhoneStyle.jpg��6   6w   	 � ColumnDefinitions	 5$   
   �� 5%      $	��250 �6   �� 5'      
 � RowDefinitions
 5*   
   �� 5+      $��75 �6   �� 5,      .+�5.   
   �� -   5        $��<��5.      $	��Top=�6    $
��Left=�5/      $��18(�50      
����������#272537���#272537$
 Hand��54   $   �� 55   
   ���#2c2f33$��6��6)   $��
0,0,0.6,-3q�6:   ._�56      �� $��1��6   $
 Hand��6.   .+�57      �� -   5         ��Name$ OutPutGoods��57      ���#F5F5DC$��70��6C   #��[ 6O   $��10 80 10 10q�58      $
 Hand��6V   ��6/   �� *OpenOutPutGoodsWnd+59      �� 5:      -   5        $ AddGoods��5:      ���#F5F5DC$��70��6@   #��[ 6L   $��10 10 10 10q�5;      $
 Hand��6S   ��6/   �� *OpenAddGoodsWnd+5=      5>      5?      �� 5@   
   $��1��6   $��3��6&   .+�5A      �� -   5         ��Name$ Welcome��5A        Welcome#���  6)   
�������$��36(�6]   $��
0 10 240 0q�6k   $��Bottom=�6   $��Center=�6�   5B      5D      5E      