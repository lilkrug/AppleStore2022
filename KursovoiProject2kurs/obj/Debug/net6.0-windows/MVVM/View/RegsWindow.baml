   M S B A M L   `   `   `  ����O  KKursovoiProject2kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KursovoiProject2kursKursovoiProject2kurs  5   	   %    KursovoiProject2kurs.RegsWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:KursovoiProject2kurs     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��RegisterUserWnd��5
   	   $	��450��5	   	   $	��700��6   $��Times New Roman)�6"     � WindowStartupLocation$  CenterScreen=�6?   $��14(�6d    � Cursor$
 Help��6s    � AllowsTransparency$
 True��6�    � WindowStyle$
 None=�6�   .��5      � ���#272537.+�5   
   �� $	��400��6   $��15q�6    
�������$��Center=�6?    �� Padding$ 30q�6Z   $	��500��6g    �� CornerRadius$ 20��6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63   	   ShadowDepth$	 0Q�6E   ._�5      �� .+�5      �� $_��YE:\Education\kursovoi2kurs2sem\KursovoiProject2kurs\Resources\Без названия.png��6   $��Center=�6q   $��49��6�   $	��171��6�   �� 5      $��Center=�6   $��Регистрация��69   $��30(�6L   $
��Bold"�6Z   ���#2725376l   �� 5       %  !MaterialDesignFloatingHintTextBox#��[  62   ��6   �� *Login+62   �� 5      $0��*pack://application:,,,/Resources/#password)�64   #��[  6m   $ Arrow��6�   ��6   �� *
Password+.��6�   
 J� InputBindings
 5      �� 5       �� Command$% ApplicationCommands.NotACommand��6%   
 �� Key$ C��5       �� 	Modifiers$ Controlf�5      �� 5      $% ApplicationCommands.NotACommand��6%   $ X��5      $ Controlf�5      .��5   -    � ContextMenu 5      �� 5!      $y�	Collapsed=�6&   .��5"   +   5#      �� 5$      $0��*pack://application:,,,/Resources/#password)�66   #��[  6o   $ Arrow��6�   ��6   �� *
RePassword+.��6�   
 5%      �� 5'      $% ApplicationCommands.NotACommand��6%   $ C��5(      $ Controlf�5)      �� 5+      $% ApplicationCommands.NotACommand��6%   $ X��5,      $ Controlf�5-      .��5.   -    5/      �� 51      $y�	Collapsed=�6&   .��52   +   53      � 54      .+�55      �� $
��Left=�6   $*��$Зарегистрироваться��68   $
��0 20q�6�   ���#272537$
 Hand��6�    �� 	IsDefault$
 True��6�   ��6U   �� *RegisterUser+��6v   ��  �� ElementName$ RegisterUserWnd��6�   �� 56      $��Right=�6   $��Вход��69   ���#272537$��284,20,0,20q�6�   $	��156��6�   $
 Hand��6�   ��6I   �� *OpenLoginUserWnd+��6n   �� $ RegisterUserWnd��6�   57      58      59      5;      5=      