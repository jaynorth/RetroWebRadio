   M S B A M L   `   `   `  ����H  DRetroWebRadio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:RetroWebRadio.View.UserControlsRetroWebRadio.View.UserControls  5      0    *RetroWebRadio.View.UserControls.RadioLists   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:RetroWebRadio.View.UserControls     5      $	��400��5	      .��5      � ��5   
   �� 5        �� ImageSource$!  ..\..\Images\CRT_Screen.png��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagridRadioList��5         AutoGenerateColumns .  
������    RowBackground
 ����    RowHeaderWidth$ 0Q�6�   $��Center=�6�   $��Center=�6     GridLinesVisibility$
 None=�6&  
������ $��0q�6\  $��20q�6p     CanUserAddRows .  ��6.   �� *StationList+ �� SelectedItem 6T   �� *CurrentStation+ �� Mode$ TwoWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+5        5#      $
 Category��6%    67   �� *
Category+5%        5&      $
 Country��6%    66   �� *	Country+5(      5+      5-      5.      