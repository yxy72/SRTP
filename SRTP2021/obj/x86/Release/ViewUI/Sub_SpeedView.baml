   M S B A M L   `   `   `  ���� C  ?SRTP2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SRTP2021.SubSpeedControlSRTP2021.SubSpeedControl  ,    &SRTP2021.SubSpeedControl.Sub_SpeedView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:SRTP2021.SubSpeedControl     .��(� .��� $	��824��$	��595������   �� ImageSource$*  $..\Assets\Images\ItemBackground2.png�� � RowDefinitions �� $
��0.2* ��� $
��0.8* �.+�� $��0�� � ColumnDefinitions �� $	��.5* ��� $	��.5* �.+��� 
�������$��速度表盘��$
��Left=�$	��Top=�$��Microsoft YaHei)�$��32(�$��
80,26,0,36q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   
BlurRadius$ 8Q�   Color$ White���� $��1��$��切换��
�������$	��Top=�$��Microsoft YaHei)�$��32(�$��215,26,0,36q�   $ 0Q�$ 8Q�$ White��� $��1�� �� $��2* ��� $��8* �.+��  �� $��30 ��� $	��.3* ��� $
��.15* ��� $	��.3* ��� $	��.3* �.+��� $��1��$��	当前：��
�������$��Right=�$��Center=�$��Microsoft YaHei)�$��48(�   $ 0Q�$ 8Q�$ White���� $��2��
�������$��Right=�$��Center=�$��Microsoft YaHei)�$��48(�$��0,0,30,0q����� *GpsIns_speed+   $ 0Q�$ 8Q�$ White���� $��3��$
��Km/h��
�������$
��Left=�$��Center=�$��Microsoft YaHei)�$��48(�   $ 0Q�$ 8Q�$ White��