   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:KursovoiProject2kurs.MVVM.ViewModel#KursovoiProject2kurs.MVVM.ViewModel  5   	   %    KursovoiProject2kurs.ShopWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   G	viewModel1clr-namespace:KursovoiProject2kurs.MVVM.ViewModel     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5        $��ShopWnd��5   	     � Title$   ��5   	   $	��600��6   $
��1000��6    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   
    � 	Resources 5         
UserCursor��%p   &	        ��5   
   RNE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\NormalSelect.cur��6t   5      .��5      �� ���#272537 � Cursor# [  6"   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5      �� -   5         ��Name$ Apple��5   +   $��Apple Store��6   $��50��6:   
�������$��22(�6Y   $��0 15 0 0q�6g   $��Center=�6y   $��Center=�6�   �� 5      $��1��6   .+�5!      	� -   5        	 	�Name$	 HomeShop��5"        HomeShop#���  5!      $��80��5#      
�������$��20(�5%        MenuBottonTheme#��[ 5&      5'      	� 5(      -   5        $	 
IPhoneShop��5)        
IPhoneShop#���  5(      $��80��5*      
�������$��20(�5,      #��[ 5-      ��5.      �� *OpenIPhoneWnd+	� 5/      -   5        $	 InformationShop��50        InformationShop#���  5/      $��80��51      
�������$��20(�53      #��[ 54      ��55      �� *OpenInformationWnd+	� 56      -   5        $
	 Exit��56        Exit#���  57      $��80��58      
�������$��20(�5:      #��[ 5;      ��5<      �� *ExitMainWnd+��5=      �� 
 �� ElementName$
 ShopWnd��5>      �� 5?      $	��250��5@      $��40��5A      $��Center=�5B      $
��Left=�5C      $��5q�5D      $��1��5E        ModernTextBox#��[ 5F      �� 5G      -   5        $��X��5H      $��40��5I      $��40��5J      ���#272537$��14(�5L      ���#272537$��Right=�5N      $	��Top=�5O      $��1��5P      $
 Hand��5Q   $   �� 5R      -   5        $��-��5S      $��40��5T      $��40��5U      ���#272537$��14(�5W      ���#272537$��Right=�5Y      $	��Top=�5Z      $��1��5[      $��0 0 40 0q�5\      $
 Hand��5]   $   �� 5_      -	   5        $��40��5`      $��60��5a      ���#272537���#272537$��1��5d      $��
80 180 0 0q�5e      $��0q�5f      $
 Hand��5g   &   
 � Tag$ en-US��5h      .��5j      �� $O��IE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\Russia1.png��6   5k      �� 5l      -
   5        $��40��5m      $��60��5n      ���#272537���#272537$��1��5q      $��-80,180,0,0q�5r      $��0q�5t      $ ru-RU��5u      $
 Hand��6   .��5v      �� $O��IE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\America.png��6   5w      � 5x      $��2��5y      $��2��5z      .+�5{      r� -   5         r�Name$ myVideo��5{      $��5q�60    r� Source$E ?E:\Phone\Представляем iPhone 13 Pro – Apple.mp4?�6;    r� LoadedBehavior$ Manual=�6t   $	��Top=�6�   �� 5|      -   5         ��Name$
 Play��5|      $
��Play��6'   
���   �$��20(�6I   
�������$��Bottom=�6j   $
��Left=�6�   $	��100��6�   $��50��6�   $��
200 0 0 15q�6�   6�   �� 5}      -   5        $
 Stop��5}      $
��Stop��6'   
���   �$��20(�6I   
�������$��Bottom=�6j   $��Right=�6�   $	��100��6�   $��50��6�   $��
0 0 200 15q�6�   6�   5~      5      5�      5�      