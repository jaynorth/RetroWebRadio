   M S B A M L   `   `   `  ����H  DRetroWebRadio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:RetroWebRadio.ViewRetroWebRadio.View  5   	   H DViewModelsXML, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullP8clr-namespace:ViewModelsXML.Tools;assembly=ViewModelsXMLViewModelsXML.Tools 5   	   Q-clr-namespace:RetroWebRadio.View.UserControlsRetroWebRadio.View.UserControls  5	   	   '    !RetroWebRadio.View.CopyMainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:RetroWebRadio.View     5   	   Jtools8clr-namespace:ViewModelsXML.Tools;assembly=ViewModelsXML     5   	   FuserControls-clr-namespace:RetroWebRadio.View.UserControls     5	   	   -   5          � WindowStyle$  SingleBorderWindow=�5   	   
���**��$	��600��5      $	��950��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ StreamRadio��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   ��5   	   ��  �� Source# Z�� �� 	Converter (  "ViewModelsXML.Tools.RatioConverter   �� ConverterParameter$	 0.6����5      �� # Z��   $	 0.6��.��5      �  � ShowGridLines .  
���   � � RowDefinitions 5   
   �� 5      $��5* �6   6*   �� 5      $��8* �6   6*   �� 5       $	��30* �6   6+   �� 5!      $��5* �6   6*   �� 5"      $	��30* �6   6+   �� 5#      $��2* �6   6*   �� 5$      $	��11* �6   6+   �� 5%      $��5* �6   6*   	 � ColumnDefinitions	 5)   
   �� 5*      $
��Auto �6   6.   �� 5+      $
��Auto �6   6.   �� 5,      $��2* �6   6,   �� 5-      $	��53* �6   6-   �� 5.      $��2* �6   6,   �� 5/      $	��41* �6   6-   �� 50      $��2* �6   6,   �� 51      $
��Auto �6   6.   �� 52      $
��Auto �6   6.   �� 53      $
��Auto �6   6.   .+�55   
   �� -   5        $	��[X]��55      $��Right=�6   $	��Top=�6<   $��96��6T   $
��Auto��6_   $��0��6m   $��6��6z   
�������
������ 6�   �� 57   
   $��1��6   $��6��6!   $��2��62   $��5��6B   
 �� RadiusX$
 18��6V    �� RadiusY$ 18��6c   ��58      �� 59       �� ImageSource$$ /Images/RustyMetal_texture.jpg��6    j� Stretch$ UniformToFill=�6J   5<      �� 5=   
   $��1��6   $��3��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��Center=�6h   .+�5?      �� -   5         ��Name$ SearchTextBox��5?      $	��180��6p   $��
0, 0, 0, 0q�6|   $��Center=�6�   $��30��6�   $��Center=�6�   
������ 
�������
���������6-   �� *searchstring+ �� UpdateSourceTrigger$ PropertyChanged=�.��65   J� InputBindings 5@      �� 5A      
 �� Key$ Return��6<    �� Command 6!   �� *Search+6<   .��5B   )   5C      �� 5D      -   5         ��Name$ SearchButton��5D      $��Search��6+   $��5,5,0,5q�6W   $��Center=�6h   $��30��6�   $��5q�6�   $��Center=�6�   
������ 
�������
���������6<   �� *Search+6�   5E      �� 5H   
   $��2��6   $��3��6   $��3��6.   
�������$��5q�6R    �� CornerRadius$ 10��6f   ._�5K      0   *RetroWebRadio.View.UserControls.RadioLists  -   5          Name$ RadioListsUC��5K   &   $��3��6<   $��2��6I   $��2��6Y   $��Stretch=�6j   $��Stretch=�6�   5L      5N      /   )RetroWebRadio.View.UserControls.Dashboard  5P   
   -   5          Name$ dashboardUserControl��5P   !   $��4��6?   $��5��6L   $��1��6\   �� 5Q   
   $��5��6   $��2��6&   
������ 
������ .@�5R      �� $��Spectrum��6   $
��Left=�6(   .��5S      9   3RetroWebRadio.View.UserControls.SpectrumUserControl  5T      �� 5U      $	��XML��6   $��Right=�6#   .��5V      0   *RetroWebRadio.View.UserControls.ProcessXML  5W      5Y      .   (RetroWebRadio.View.UserControls.EditList  5[   
   $��6��6    $��3��6-   6?   5]      5_      