   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:KursovoiProject2kurs.MVVM.ViewKursovoiProject2kurs.MVVM.View  5   	   ,    &KursovoiProject2kurs.MVVM.View.Support   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:KursovoiProject2kurs.MVVM.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
SupportWnd��5	   �     � Title$  Support��6	   $	��600��6   $
��1000��6&    � SizeToContent$ Manual=�63    � 
ResizeMode$ 	CanResize=�6J    � WindowStartupLocation$ CenterScreen=�6a   $��Visible=�6�    � UseLayoutRounding$
 True��6�    � AllowsTransparency$
 True��6�    � WindowStyle$
 None=�6�    � 	Resources 5
         
UserCursor��%p   &	        ��5   
   RNE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\NormalSelect.cur��6t   5      .��5      � ���#272537 � Cursor# [  6    .+�5   
   �� $U��OE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\AppleSupport1.png��6   $��Center=�5      $	��Top=�5      $	��600��5      �� 5   
   -   5        $��<��5      $	��Top=�6    $
��Left=�5      $��18(�5      
����������#272537���#2725375      �� 5   
   $	��400��6   $��15q�6    
�������$��Center=�6?   	 �� Padding$	 30q�6Z   $	��500��6g   
 �� CornerRadius$
 20��6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $��Center=�6   $��
Contact Us��69   $��30(�6K   $
��Bold"�6Y   ���#2725376k   �� 5       -   5        $��EmailTexBox��5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6-    % !MaterialDesignFloatingHintTextBox#��[ 6j   $��50��6�   $��18(�6�   ��6T   �� *Mail+6�   �� 5!      -   5        $��SubjectTexBox��5!      $ Subject��6/   #��[ 6q   $��50��6�   $��18(�6�   ��6X   �� *	Subject+6�   �� 5"      -   5        $��MessageTexBox��5"      $ Message��6/   #��[ 6q   $	��150��6�   $��20(�6�   ��6X   �� *	Message+6�   � 5#      .+�5$      �� $��Center=�6   $
��Send��6:   ���#272537$	��156��6�   $ Arrow��6�   ��6I   �� *SendMessage+��6i   ��  �� ElementName$ 
SupportWnd��6�   5%      5&      5'      5)      5*      