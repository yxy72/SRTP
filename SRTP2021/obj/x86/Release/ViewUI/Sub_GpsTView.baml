   M S B A M L   `   `   `  ���� C  ?SRTP2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SRTP2021.SubGpsLControlSRTP2021.SubGpsLControl  *    $SRTP2021.SubGpsTControl.Sub_GpsTView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:SRTP2021.SubGpsLControl     -   $��SubGpsTControl��.��(� .��� $	��661��$	��389������   �� ImageSource$*  $..\Assets\Images\ItemBackground3.png�� � RowDefinitions �� $
��0.3* ��� $
��0.8* �.+��� $��环境数据��
�������$
��Left=�$	��Top=�$��Microsoft YaHei)�$��32(�$��
80,25,0,36q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   
BlurRadius$ 8Q�   Color$ White��A� $��1�� A� Rows$ 2��$��0,5,0,30q�.+��  � ColumnDefinitions �� $	��.5* ��� $	��.5* �.+��� $��0��$��	温度：��
�������$��Center=�$��Center=�$��Microsoft YaHei)�$��56(�$��	100,0,0,0q�   $ 0Q�$ 8Q�$ White���� $��1��
�������$
��Left=�$��Center=�$��Microsoft YaHei)�$��64(����� *GpsIns_temperature+   $ 0Q�$ 8Q�$ White���  �� $	��.5* ��� $	��.5* �.+��� $��0��$��	湿度：��
�������$��Center=�$��Center=�$��Microsoft YaHei)�$��56(�$��	100,0,0,0q�   $ 0Q�$ 8Q�$ White���� $��1��
�������$
��Left=�$��Center=�$��Microsoft YaHei)�$��64(����� *GpsIns_humidity+   $ 0Q�$ 8Q�$ White��