   M S B A M L   `   `   `  ���� C  ?SRTP2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SRTP2021SRTP2021  1clr-namespace:SRTP2021.ViewUISRTP2021.ViewUI      SRTP2021.MainView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:SRTP2021     0suballclr-namespace:SRTP2021.ViewUI     -   $��
MainWindow��$
��1080��$
��1920��  � Title$  行车综合监控系统��$��Microsoft YaHei)�$��
ExtraLight"�$��12(� � WindowStyle$
 None=� � AllowsTransparency .  � 	Resources  �� Source�� $( "../Assets/Styles/DefaultStyle.xaml?�%    ����  �� ImageSource$) #../Assets/Images/backgroundHigh.jpg��.����  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$
 Gray��   ShadowDepth$ 0Q�	   
BlurRadius$	 0Q�
   Opacity$	
 0.3Q�   	Direction$ 0Q�._��  � RowDefinitions �� $��66 ��� $��1* ��� $��45 �.+��� $��2��$��45��$��Bottom=�._��  �� $��1 ��� $
��.95* �.+��� ���#262392$��0,0,0,1q�$��Center=�A�  A� Columns$ 7��$��1�����#0E0D37.+�� .+��� -   $��btnFocus��$��全局监控��   BottomBtnStyle#��[  ���� *CloseWindowCommand+����  �� ElementName$ 
MainWindow��� .+��� -   $��	GPS定位��#��[  ���� *CloseWindowCommand+���� $ 
MainWindow��� .+��� $��速度表盘��#��[  ���� *CloseWindowCommand+���� $ 
MainWindow��� .+��� $��环境参数��#��[  ���� *CloseWindowCommand+���� $ 
MainWindow��� .+��� $��雷达检测��#��[  ���� *CloseWindowCommand+���� $ 
MainWindow��� .+��� $��设置面板��#��[  ���� *CloseWindowCommand+���� $ 
MainWindow��� .+��� -   $��退出程序��#��[  ���� *CloseWindowCommand+���� $ 
MainWindow���� $��0��$��66��$
��1920��$	��Top=����� $  ../Assets/Images/title.png��._�A� $ 3��$��0,0,0,5q�.+��� $��  你好，admin��
�������$��20(�$
��Left=�$��Bottom=��� �� -   $	��cnm��
�������$��20(�$
��Left=�$��Bottom=����� *
DateTime+�� $��0�� �� Orientation$ 
Horizontal=�$	��Top=�$��Right=�.+��� -   $��40��$��40��  WindowControlButtonStyle#��[ $	������ -   $��40��$��40��#��[ $	����� -   $��mainUIPlatform��$��1�� �� $��40 ��� $��1* ��� $��60 �.+�$   SRTP2021.ViewUI.SubCon_GpsView  $��1��$��Center=�$
��Left=�$��80,0,0,0q�