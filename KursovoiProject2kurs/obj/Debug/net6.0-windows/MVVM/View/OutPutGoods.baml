   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:KursovoiProject2kurs.MVVM.ViewKursovoiProject2kurs.MVVM.View  5   	   0    *KursovoiProject2kurs.MVVM.View.OutPutGoods   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:KursovoiProject2kurs.MVVM.View     5   	   -   5        $��OutPutGoodsWnd��5	   	     � Title$  OutPutGoods��5   	   $	��600��6   $
��1100��6*    � WindowStartupLocation$ CenterScreen=�68   $��Visible=�6^    � AllowsTransparency$
 True��6�    � WindowStyle$
 None=�6�    � Cursor$
 Hand��6�    � 	Resources 5
         
UserCursor �� 
TargetType  
ButtonText �� Property �� Value 	 Texts��%�  &	        &	 f     &	 N    ��5   
   RNE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\NormalSelect.cur��6t   �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � �� �#2725376+   �� 5       � ��$ 18(�6)   �� 5       � �� �#2725376,   �� 5       � ��
 �����6+   5      �� 5   
   " ��6   .�5      ��  � �� �#99aab56+   �� 5       � ��$ 24(�6)   5      5      .��5      � # [  6   ���#F5F5DC	 � RowDefinitions	 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� -   5        $��<��5      $	��Top=�6    $
��Left=�5      
�������$��40��5!      $��30��5"      #��[ 5#      $
 Hand��5$   $   �� 5%   
   $��5��6   $��0��6)   $��40 0 0 0q�69   
 �� SelectedItem
 6K   �� *SelectedTabItem+.@�5&      �� -   5        $��UsersTab��5&      ��5'      �� 5(      $��Users��6    .��5*      �� -   5         ��Name$ ViewAllUsers��5*      ��61   �� *
AllUsers+ �� View 5+      �� 5,      .P�5-      �� $��Id��6-    �� DisplayMemberBinding 5.   -   ��  �� Path$ Id��� 5/      $��Login��6-    50   -   �� $ Login��� 51      $��Password��6-    52   -   �� $ Password�53      55      56      �� 59      -   5        $��GoodsTab��59      ��5:      �� 5;      $��Goods��6     � ContextMenu 5=      �� 5>      .@�5?      m� $"��Редактирование��6#    m� Command 6;   �� *OpenEditItemWnd+m� 5@      $��Удалить��6#    64   �� *
DeleteItem+5A      .��5C      �� -   5        $��ListViewTable��5D      $��5��5G      $��0��5H      $��5��5I      $��1��5J      $��0,0.6,-0.4,0q�5K      ��5E      �� *
AllGoods+
 5F      �� *SelectedGoods+ 5L      �� 5M      .P�5N      �� $��ID��6%    61   �� $ Id��� 5O        ItemPicture#���  6&    �� Width$	 150��6M    �� CellTemplate 5P      �� 5Q      .R�5R   "   �� $��60��6R   $��60��6^   $��0,20,0,0q�6i   $��UniformToFill=�6{   ��6(   �� $ NoteImage.Picture�6{   5S      5U      �� 5V        
ItemNameLC#���  6%   $	 160��6K    6W   �� $
 Name��� 5W        
CategoryLC#���  6%   $	 130��6K    6W   �� $ Category��� 5X        PriceLC#���  6%   $	 100��6H    6T   �� $ Price��� 5Y        	CountryLC#���  6%   $	 165��6J    6V   �� $ Country��� 5Z        Description#���  6%   $	 170��6L    6X   �� $ Description�5m      5o      5p      �� 5s      -   5        $��	OrdersTab��5s      ��5t      �� 5u      $��Orders��6    .��5w      �� -   5        $ ViewAllOrders��5w      ��62   �� *	AllOrders+ 5x      �� 5y      .P�5z      �� $��Id��6-    5{   -   �� $ Id��� 5|      $��Good Id��6-    5}   -   �� $ GoodId��� 5~      $��User Id��6-    5   -   �� $ UserId�5�      5�      5�      5�      5�      5�      