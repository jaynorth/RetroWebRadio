   M S B A M L   `   `   `  ���� H  DRetroWebRadio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:RetroWebRadio.View.UserControlsRetroWebRadio.View.UserControls  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 0    *RetroWebRadio.View.UserControls.ProcessXML   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:RetroWebRadio.View.UserControls     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity       � 	Resources     BrowseStyle1 �� 
TargetType �� Property  FocusVisual �� Value  Button.Static.Background  Button.Static.Border �� 
TargetType �� RadiusY �� RadiusX �� EndPoint �� 
StartPoint	 � Color
 � Offset ��Name �� Triggers P� Property P� Value��%t  &	        7  7  7  �� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R�� $��18.91��$��62.04��.+��� $	 4.5��$	 4.5��
���   ����� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FF818181��$
 0Q�� $	 White��$
 1Q��� $ 	textBlock��$
��Wrap=�$��Browse��$��Center=�$��Center=�$��13(�$��Century Gothic)�
���   � P�  �@��IsDefaulted . P�  �@J�IsMouseOver . P�  � �� . P�  � {� .  .���  � ShowGridLines .  ����  �� ImageSource$b \D:\Visual Studio Projects\Projects\RetroWebRadio\RetroWebRadio\Images\Brushed_metal_text.jpg�� j� Stretch$ UniformToFill=� � RowDefinitions �� $	��33* ��� $	��33* ��� $	��33* � � ColumnDefinitions �� �� .+��� $��0��$��Center=�$��5q�.+��� 
�������$��0q� �� CornerRadius$ 6�� �� Padding$ 2q�._���  �� Orientation$ Vertical=�$��Center=�.+��� $��Import XML File���� $��Browse��$
��Auto��#���   ���� *Browse+�� $��2��$��Center=�$��5q�.+��� 
�������$��0q�$ 6��$ 2q�._��� $ Vertical=�$��Center=�$��1��.+��� $��Save Main XML���� $
��Save��$
��Auto��  ButtonStyleXML3#���  ���� *Save+�� $��1��$��Center=�$��5q�.+��� 
�������$��0q�$ 6��$ 2q�._��� $ Vertical=�$��Center=�$��2��.+��� $)��#Process Files in Application Folder��
���   ��� 
���   ����� *FileList.Count+ �� StringFormat$$ Currently {0} file(s) waiting ���� $��Process��$
��Auto��  ProcessStyle1#���  ���� *ToBeProcessed+�� $��0��$��1��$��3��$ Vertical=�$��Center=�$��Center=�.+��� $'��!Drag and Drop XML files to import���� -    ��Name$ listDrop��$
��Auto��$
��Auto��$	��105��$	��180��$��5q� J� 	AllowDrop . ���� *DroppedItems+�� $��Import��$��40��  ImportStyle1#���  ���� *Import+