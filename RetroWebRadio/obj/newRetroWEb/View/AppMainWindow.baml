   M S B A M L   `   `   `  ���� H  DRetroWebRadio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:RetroWebRadio.ViewRetroWebRadio.View  H DViewModelsXML, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullP8clr-namespace:ViewModelsXML.Tools;assembly=ViewModelsXMLViewModelsXML.Tools Q-clr-namespace:RetroWebRadio.View.UserControlsRetroWebRadio.View.UserControls  '    !RetroWebRadio.View.CopyMainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:RetroWebRadio.View     Jtools8clr-namespace:ViewModelsXML.Tools;assembly=ViewModelsXML     FuserControls-clr-namespace:RetroWebRadio.View.UserControls     -     � WindowStyle$  SingleBorderWindow=�
���**��$	��600��$	��950�� � WindowStartupLocation$ CenterScreen=� � Title$ StreamRadio�� � 
ResizeMode$ CanResizeWithGrip=�����  �� Source# Z�� �� 	Converter (  "ViewModelsXML.Tools.RatioConverter   �� ConverterParameter$	 0.6������ # Z��   $	 0.6��.���  � ShowGridLines .  
���   � � RowDefinitions �� $��5* ��� $��5* ��� $	��30* ��� $��5* ��� $	��30* ��� $��2* ��� $	��13* ��� $��5* �	 � ColumnDefinitions	 �� $
��Auto ��� $
��Auto ��� $��2* ��� $	��53* ��� $��2* ��� $	��41* ��� $��2* ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $	��[X]��$��Right=�$	��Top=�$��96��$
��Auto��$��0��$��6��
�������
������ �� $��1��$��6��$��2��$��5��
 �� RadiusX$
 18�� �� RadiusY$ 18������  �� ImageSource$$ /Images/RustyMetal_texture.jpg�� j� Stretch$ UniformToFill=��� $��2��$��3��$��3��
�������$��5q� �� CornerRadius$ 10��._�0   *RetroWebRadio.View.UserControls.RadioLists  -     Name$ RadioListsUC��$��3��$��2��$��2��$��Stretch=�$��Stretch=�/   )RetroWebRadio.View.UserControls.Dashboard  -     Name$ dashboardUserControl��$��4��$��5��$��1���� $��5��$��2��
������ 
������ .@��� $��Spectr��$
��Left=�.��9   3RetroWebRadio.View.UserControls.SpectrumUserControl  �� $	��XML��$��Right=�.��0   *RetroWebRadio.View.UserControls.ProcessXML  .   (RetroWebRadio.View.UserControls.EditList  $��6��$��3��