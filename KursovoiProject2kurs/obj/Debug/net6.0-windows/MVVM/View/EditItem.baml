   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:KursovoiProject2kurs.MVVM.ViewKursovoiProject2kurs.MVVM.View  5   	   -    'KursovoiProject2kurs.MVVM.View.EditItem   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:KursovoiProject2kurs.MVVM.View     5   	   -   5        $��EditGoodsWnd��5	   	     � Title$  EditItem��5   	   $	��600��6   $
��1000��6'    � WindowStartupLocation$ CenterScreen=�64   $��Visible=�6Y    � AllowsTransparency$
 True��6�    � WindowStyle$
 None=�6�    � 	Resources 5
         
UserCursor �� 
TargetType  btTemplate1 �� CornerRadius  EditPicture  btTemplate4  SaveInfo �� 
TargetType 
 Texts1 �� Property	 �� Value  
paramsText��%�  &	        &	 f     &	 >    &	     &	 �    ��5   
   RNE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\NormalSelect.cur��6t   �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��35��5   *   ._�5      �� $��16(�6"   $��Center=�60   $��Center=�6M   #���  6h   
���   �6�   5      5      �� 5   
   " ��6   .R�5      �� $ 25��6   ���#F5F5DC���#F5F5DC$��45��5   *   ._�5      �� $��16(�6!   $��Center=�6/   $��Center=�6L   #���  6g   
���   �6�   5      5      �� 5   
   " ��6   .�5      ��  � ��	 �#99aab56+   �� 5       �@��TextAlignment$	 Center=�6.   �� 5       � ��$	 24(�6)   5      �� 5   
   " ��6   .�5      ��  � ��	 �#99aab56+   �� 5       � ��$	 22(�6)   �� 5        �@��TextAlignment$
	 Left=�6.   5!      5#      .��5$      �� ���#272537
 � Cursor#
 [  6"   ._�5%   
   �  � ColumnDefinitions 5&      �� 5'      $	��400 �6#   �� 5)       � RowDefinitions 5,      �� 5-      $��50 �6    �� 5.      .+�50      �� -   5        $��<��50      $	��Top=�6$   $
��Left=�51      $��18(�52      
����������#272537���#272537$

 Hand��56   $   �� 57      $��2��6   .+�58      �� -   5         ��Name$ 	EditItems��58        EditItem#���  6/   #��[ 6Q   $��50 0 0 0q�6q   59      �� 5:      $��1��6   $��1��6/   $��10��6<   .+�5;      �� -   5         ��Name$ ItemPicture��5;      $	��350��6-   $	��350��6:   $��
10,20,10,0q�6F   $��Center=�6Z   $��Center=�6u   $N��HE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources/Basket.jpg��6�   �� 5<      -   5         ��Name$ ButtonSaveInfo��5<      $	��230��61   $��	10,15,0,0q�6>   $��65��6Q   #��[ 6^   $

 Hand��5=   G   ��5<   �   �� *	EditGoods+��5=      ��  �� ElementName$ EditGoodsWnd��6G   5?      �� 5@      $��2��6   $��2��6)   .+�5A      �� $��1��6   $��2��6*   $��54��6:   .+�5B      �� -   5        $ TextBlockNameGood��5B       #��[ 6;     ItemName#���  6_   6�   �� 5C      -   5         ��Name$ TextBoxNameGood��5C      $	��150��6T   $��160,-24,0,0q�6`   $��30��6u   
�������$
 Arrow��6�   ��68   �� *
IPhoneName+6�   5D      �� 5E      $��2��6   $��2��6*   $��54��6:   .+�5F      �� -   5        $ TextBlockCategory��5F       #��[ 6;    	 Category#��� 	 6_   6�   �� 5G      -	   5        $ TextBoxCategory��5G      $	��150��6W   $��30��6c   $��160,-22,0,0q�6o   
���������67   �� *IPhoneCategory+6�   5H      �� 5I      $��3��6   $��2��6*   $��53��6:   .+�5J      �� -
   5        $ TextBlockPrice��5J       #��[ 68    	
 Price#��� 
 6\   6}   �� 5K      -   5        $ TextBoxPrice��5K      $	��100��64   $��160,-24,50,0q�6]   $��30��6s   
�������$
 IBeam��6�   ��6@   �� *IPhonePrice+6�   �� 5L      -   5        $ TextBlockCurrency��5L       #��[ 6;   $��50��6_   $��20��6j   $��300,-20,0,0q�6v     Currency#���  6�   6�   5M      �� 5N      $��4��6   $��2��6*   $��53��6:   .+�5O      �� -   5        $ TextBlockCountry��5O       #��[ 6:     Country#���  6^   6�   �� 5P      -   5        $ TextBoxCountry��5P      $	��150��6U   $��160,-24,0,0q�6a   $��30��6v   
���������66   �� *IPhoneCountry+6�   5Q      �� 5R      $��6��6   $��2��6*   $	��264��6:   .+�5S      �� -   5        $ TextBlockDescription��5S       #��[ 6>     Description#���  6b   6�   �� 5T      -   5        $ TextBoxDescription��5T      $	��320��6]   $	��180��6i   $��
-10,20,0,0q�6v   
���������6:   �� *IPhoneDescription+6�   5U      5V      5W      5X      5Z      