   M S B A M L   `   `   `  ����  Masterclass.Revit.20214    .MasterclassRevit.SecondButton.SecondButtonView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5local#using:MasterclassRevit.SecondButton     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          �Name$	  Win��5      $��Comic Sans MS)�5
      $��15(�5       � SizeToContent$ Height=�5      $	��800��5       � Title$ AEC Tech - SecondButton��5       � WindowStartupLocation$ CenterScreen=�5      $��0,5,0,0q�5      
���  �� � 	Resources 5         DefaultRowStyle �� 
TargetType)  #System.Windows.Controls.DataGridRow �� Property �� Value��%l   &	        �� 5   
   "  6(   .�5      ��  �@ 
IsSelected 6+   �� *
IsSelected+5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   &   System.Windows.Controls.DataGrid  	   RowStyle#	 [  5      
   AutoGenerateColumns
 .  "   VerticalScrollBarVisibility$
 Auto=�5      $   HorizontalScrollBarVisibility$ Hidden=�5         CanUserAddRows .     CanUserResizeColumns .     CanUserSortColumns .     
IsReadOnly .     SelectionMode$ Extended=�5$         SelectionUnit$ FullRow=�5%      $	��400��5&      $��15q�5'      ��5      �� *SpatialObjects+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5+   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5*   %   �� *Name+$ OneWay=�5+   %     5,      $
 Area��6%   $	 200 5.   %      
IsReadOnly .  5-   %   �� *Area+$ OneWay=�5/   %   51      �� 52   
   $��1��6   $��75��53      $��25��54      $��Right=�55      $��Center=�56      $��0,0,15,0q�57      $��Close��58      ��59      �� *Close+$ OneWay=���5:      ��  �� ElementName$	 Win���� 5;   
   $��1��6   $��75��5<      $��25��5=      $��Right=�5>      $��Center=�5?      $��	0,0,100,0q�5@      $��Delete��5A      ��5B      �� *Delete+$ OneWay=���5C      �� $	 Win��5D      5E      