   M S B A M L   `   `   `  ����H  DRetroWebRadio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:RetroWebRadio.View.UserControlsRetroWebRadio.View.UserControls  5      /    )RetroWebRadio.View.UserControls.Dashboard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:RetroWebRadio.View.UserControls     5      -   5          >�Name$  closed��5   J   .��5      �  � ShowGridLines .  ��5   
   �� 5       �� ImageSource$) #../../Images/Brushed_metal_text.jpg��6    j� Stretch$ UniformToFill=�6K    � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $	��30* �6   �� 5      $��4* �6   �� 5      $	��20* �6   �� 5      $	��26* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5       $��* �6    �� 5!      $��* �6   �� 5"      $��50 �6   �� 5#      $��10 �6   .+�5'   
   �� 
������� �� CornerRadius$ 3,3,3,3��6$   $��2,2,2,2q�6;   $��1��6U   $��1��6b   $��4��6r   ��5(      �� 5)      $> 8..\..\Images\pg278q_taskbar_vertical_bars_notvisible.png��6   $ UniformToFill=�6d   ._�5,      �� .+�5.      �� -   5         ��Name$ 
displayBox��5.      $��SemiExpanded&�60   
���/���$��4q�6d   $��Stretch=�6o   �� 6�   $�Ready��6�   6�   �� 5/      -   5        $ StationInfoText��5/      $��SemiExpanded&�65   
���/���$��4, 10q�6i   $��Bottom=�6x   $��Italic$�6�   ��6�   �� *CurrentStation.Name+52      53      �� 54   
   -   5         ��Name$ play_button��54      $
��Play��6'   $��1��66   $��3��6F   $
��Auto��6t   $
��Auto��6�      
PauseStyle#���   6�   �� 55   
   -   5        $ pause_button��55      $��Pause��6(   $��2��69   $��3��6J   ���	#FFDDDDDD#���   6�   �� 57   
   -   5        $ stop_button��57      $
��Stop��6&   $��3��65   $��3��6E   #���   6m   $��0,0.7,0,-0.384q�6�   �� 59   
   $��Volume��6   $��Center=�6!   $��Center=�6<   $��4��6Y   $��1��6f   $��SemiBold"�6v   6�   �� 5:   
   -   5        	 ��Name$	 volumeSlider��5:      $��4��6(   $��2��65   $��2��6E   
 �� Orientation$
 
Horizontal=�6Y    � Minimum$ 0Q�6�    � Maximum$ 1Q�6�   $��Center=�6�   $��Stretch=�6�   $
��Auto��6�    � Value$ 0Q�6�    �� TickPlacement$ TopLeft=�6   �� TickFrequency$	 0.1Q�6     SliderStyle1#���  64    SliderHorizontal#���  6[  r� 5=   
   -   5         r�Name$ Player��5=       r� LoadedBehavior$ Manual=�6'    r� Volume$ 0Q�6C   5@      5B      