   M S B A M L   `   `   `  ����H  DRetroWebRadio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:RetroWebRadio.View.UserControlsRetroWebRadio.View.UserControls  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      0    *RetroWebRadio.View.UserControls.ProcessXML   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:RetroWebRadio.View.UserControls     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5        � 	Resources  5      ��%    5      .��5      �  � ShowGridLines .  ��5   
   �� 5       �� ImageSource$) #../../Images/Brushed_metal_text.jpg��6    j� Stretch$ UniformToFill=�6K    � RowDefinitions 5   
   �� 5      $	��33* �6   6+   �� 5      $	��33* �6   6+   �� 5      $	��33* �6   6+    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5!   
   �� $��0��6   $��Center=�6"   $��5q�6=   .+�5"      �� 
�������$��0q�6(    �� CornerRadius$ 6��6<    �� Padding$ 2q�6M   ._�5#      ��  �� Orientation$ Vertical=�6   $��Center=�64   .+�5$      �� $��XML File��6   61   �� 5%      $��Browse��6   $
��Auto��6I      BrowseStyle1#���   6W   ��6.   �� *Browse+6�   5&      5'      5(      �� 5)   
   $��2��6   $��Center=�6"   $��5q�6=   .+�5*      �� 
�������$��0q�6(   $ 6��6<   $ 2q�6M   ._�5+      �� $ Vertical=�6   $��Center=�64   $��1��6Q   .+�5,      �� $��Main XML��6   61   �� 5-      $
��Save��6   $
��Auto��6E     ButtonStyleXML3#���  6S   ��6,   �� *Save+6   5.      5/      50      �� 51   
   $��1��6   $��Center=�6"   $��5q�6>   .+�52      �� 
�������$��0q�6(   $ 6��6<   $ 2q�6M   ._�53      �� $ Vertical=�6   $��Center=�64   $��2��6Q   .+�54      �� $!��Files in Application Folder��6    
���   �6C   �� 55      
���   ���6!   �� *FileList.Count+	 �� StringFormat$$	 Currently {0} file(s) waiting ��6�   �� 57      $��Process��6   $
��Auto��6Q     ProcessStyle1#���  6_   ��6/   �� *ToBeProcessed+6�   58      59      5:      �� 5=   
   $��0��6   $��1��6"   $��3��62   $ Vertical=�6C   $��Center=�6Z   $��Center=�6u   .+�5>      �� $'��!Drag and Drop XML files to import��6   6B   �� 5?      -   5        
 ��Name$
 listDrop��5?      $
��Auto��6(   $
��Auto��66   $	��105��6C   $	��180��6S   $��5q�6b    J� 	AllowDrop . ��6�   �� *DroppedItems+5A      �� 5B      $��Import��6   $��40��6A     ImportStyle1#���  6L   ��6&   �� *Import+6v   5D      5I      5J      