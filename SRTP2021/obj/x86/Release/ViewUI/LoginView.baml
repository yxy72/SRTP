   M S B A M L   `   `   `  ���� C  ?SRTP2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SRTP2021.ViewSRTP2021.View  1clr-namespace:SRTP2021.CommonSRTP2021.Common      SRTP2021.View.LoginView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:SRTP2021.View     0commonclr-namespace:SRTP2021.Common     -   $��LoginWindow��$	��520��$	��360��  � Title$  系统登录��$��Microsoft Yahei)�$��
ExtraLight"� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . ��Z�  � 	Resources  �� 
TargetType   	BtnStyle1 �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value  LoginButtonTemplate �� CornerRadius  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  UserNameTextBoxStyle �� 
TargetType-  'System.Windows.Input.KeyboardNavigation ��Name J� SnapsToDevicePixels � ColumnDefinitions ��Name �� Triggers ]� 
Conditions �� Property �� Value  PasswordBoxStyle  VlidationCodeTextBoxStyle��%�  &	        &	     &	 6    &	 K    &	 `    &	 u    7  7  7  &	 J    7  7  7  &	 C
    7  7  7  �� " ��.R��� $
��back��
������ ._�F� +����        � �  � �     � � �     	
�������$��1��$��Center=�$��Center=� P�  �@J�IsMouseOver	 . . ��� $

 back�� � �� �	#44ffffffP�  � ��	 . . ��� $

 back�� � �� �	#22ffffff�� " ��.R��� ���#007dfa$ 9��._�� .+��� $��login��$ 4�����	#22FFFFFF�� #��z��$��Center=�$��Center=�#��z�� P�  �@J�IsMouseOver	 . . ��� $
 login�� � �� �	#44ffffffP�  � ��	 . . ��� $
 login�� � �� �	#22ffffff�� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . $ 5��._��  �� $��40 ��� .+��� $	����
�������$��4��$+��%../Assets/Fonts/iconfont.ttf#iconfont)�$��23(�$��Center=�$��Center=��� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�$��20�� P�  � {�	 .  . ��� $
 border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver	 . . ��� $
 border��8   � ��P�  �@J�IsKeyboardFocused	 . . ��� $
 border��8   � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /��� " G�.���  �@G�PasswordChar$	 ●����  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " G�.R��� $ border��#��z��#��z��#��z�� . $ 5��._��  �� $��40 ��� .+��� $	����
�������$��4��$+��%../Assets/Fonts/iconfont.ttf#iconfont)�$��26(�$��Center=�$��Center=��� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�$��20�� P�  � {�	 .  . ��� $
 border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver	 . . ��� $
 border��8   � ��P�  �@J�IsKeyboardFocused	 . . ��� $
 border��8   � �� ]�  �� + �@G�#IsInactiveSelectionHighlightEnabled . ��  �@G�IsSelectionActive .  ./���  �@G�SelectionBrush# � /��� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . $ 5��._��  �� $��40 ��� �� $��80 �.+��� $	����
�������$��4��$+��%../Assets/Fonts/iconfont.ttf#iconfont)�$��23(�$��Center=�$��Center=��� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�$��20�� P�  � {�	 .  . ��� $
 border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver	 . . ��� $
 border��8   � ��P�  �@J�IsKeyboardFocused	 . . ��� $
 border��8   � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /�.���� $��5q�
�������$ 10�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$
 Gray��   ShadowDepth$ 0Q�   
BlurRadius$ 5Q�   Opacity$	 0.3Q�   	Direction$ 0Q�._��  � RowDefinitions �� $
��1.8* ��� $��3* �.+��� -   ���#007DFA$ 	10,10,0,0���� -   $	��Top=�$��30��#��[  $��	320,0,0,0q�$
��Left=�$��30������ *CloseWindowCommand+����  �� ElementName$ LoginWindow���� $��Bottom=�$��0,0,0,25q�.+��� 
�������$��Center=�$��Center=�$ 60��$��0,0,0,10q�   $ White��$ 0Q�$ 10Q�$	 0.3Q�$ 0Q�._��� $��85��$��85��$��Center=�����   �� ImageSource$  ../Assets/Images/icn0.png���� $$��登陆列车综合监控系统��$��Center=�
�������$��18(�   $ black��$ 0Q�$ 0Q�$ 0Q�� $��1��$��24,20,24,20q�! +� FocusedElement! �� $ UserNameText�� �� �� �� �� �� .+��� -   $��UserNameText��$��40��$��15(����#555#���  ���� *loginVal.UserName+" �� UpdateSourceTrigger$" PropertyChanged=�.��.��# J� InputBindings# �� 
$ �� Key$$ Enter��% �� Command% �� *LoginCommand+& �� CommandParameter& �� $ LoginWindow��.��G� $��1��#���  $��40��$��15(����#555$   SRTP2021.Common.PasswordHelper'   Attach' . (   Password( �� *loginVal.Password+) �� Mode$) TwoWay=�$" PropertyChanged=��� $��2��$��40��$��15(����#555#���  �� -   $��登  录��$��3��#��[ 
�������$��18(�$��0,6,0,9q�* �� 	IsDefault* . ���� *LoginCommand+���� $ LoginWindow���� 
���  ��$��4��$0��*../Assets/Fonts/InitialViewFT.ttf#iconfont)�$��15(�$
��Wrap=�+ �� 
LineHeight$+ 20������ *ErrorMessage+