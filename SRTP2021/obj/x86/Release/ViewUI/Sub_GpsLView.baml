   M S B A M L   `   `   `  ���� C  ?SRTP2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SRTP2021.SubGpsLControlSRTP2021.SubGpsLControl  *    $SRTP2021.SubGpsLControl.Sub_GpsLView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:SRTP2021.SubGpsLControl     -   $��SubGpsControl��.��(� .��� $	��824��$	��595������   �� ImageSource$*  $..\Assets\Images\ItemBackground2.png�� � RowDefinitions �� $
��0.2* ��� $
��0.8* �.+�� $��0�� � ColumnDefinitions �� $	��.5* ��� $	��.5* �.+��� $��
GPS 数据��
�������$
��Left=�$	��Top=�$��Microsoft YaHei)�$��32(�$��
80,26,0,36q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   
BlurRadius$ 8Q�   Color$ White���� $��1��$��最新��
�������$	��Top=�$��Microsoft YaHei)�$��32(�$��215,26,0,36q�   $ 0Q�$ 8Q�$ White��� $��1�� �� $	��.3* ��� $	��.7* �.+��� $��0��$��GPS  (Current)��
�������$
��Left=�$��Center=�$��Microsoft YaHei)�$��72(�$��60,0,0,0q�   $ 0Q�$ 8Q�$ White��A� $��1�� A� Rows$ 3��$��160,10,0,50q�.+��  �� $
��.35* ��� $
��.65* �.+��� $��0��$��	经度：��
�������$��Center=�$��Center=�$��Microsoft YaHei)�$��56(�   $ 0Q�$ 8Q�$ White���� $��1��
�������$
��Left=�$��Center=�$��Microsoft YaHei)�$��64(����� *GpsIns_longitude+   $ 0Q�$ 8Q�$ White���  �� $
��.35* ��� $
��.65* �.+��� $��0��$��	纬度：��
�������$��Center=�$��Center=�$��Microsoft YaHei)�$��56(�   $ 0Q�$ 8Q�$ White���� $��1��
�������$
��Left=�$��Center=�$��Microsoft YaHei)�$��64(����� *GpsIns_latitude+   $ 0Q�$ 8Q�$ White���  �� $
��.35* ��� $
��.65* �.+��� $��0��$��	高度：��
�������$��Center=�$��Center=�$��Microsoft YaHei)�$��56(�   $ 0Q�$ 8Q�$ White���� $��1��
�������$
��Left=�$��Center=�$��Microsoft YaHei)�$��64(����� *GpsIns_height+   $ 0Q�$ 8Q�$ White��