   M S B A M L   `   `   `  ���� H  DRetroWebRadio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:RetroWebRadio.View.UserControlsRetroWebRadio.View.UserControls  0    *RetroWebRadio.View.UserControls.RadioLists   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:RetroWebRadio.View.UserControls     $	��400��  � 	Resources   �� 
TargetType �� Property �� Value&   System.Windows.Controls.DataGrid*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '��       '  U     '  z     '  B    �� " ��.���  � ��
 ���� ��  � ��
 �  ����  � ��
 �/����� "  .���  � ��
 �/����� "  .���  � ��$ 11, 0, 11, 0q� P�  �@ 
IsSelected . . ���  � ��
 � �����  � ��
 ���� ��  � ��
 ���� ��  � ��$
 Bold"���  � ��$ 0q��� "  .���  � ��
 �/�����  � ��$
 Bold"���  � ��
 ���� ��  � ��$ 11, 9, 0, 20q�.��� ����  �� ImageSource$Z TD:\Visual Studio Projects\Projects\RetroWebRadio\RetroWebRadio\Images\CRT_Screen.png��.+�  -     Name$ datagridRadioList��	   AutoGenerateColumns	 .  
������ 
   RowBackground

 ����    RowHeaderWidth$ 0Q�$��Center=�$��Center=�   GridLinesVisibility$
 None=�
������ $��0q�$��20q�   CanUserAddRows .  ���� *StationList+ �� SelectedItem �� *CurrentStation+ �� Mode$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� .��[X]  $ Category�� �� *
Category+  $ Country�� �� *	Country+