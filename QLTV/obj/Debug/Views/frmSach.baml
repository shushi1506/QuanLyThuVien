   M S B A M L   `   `   `  ����?  ;QLTV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QLTV.Views
QLTV.Views  5          QLTV.Views.frmSach   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:QLTV.Views     5      j fDevExpress.Xpf.LayoutControl.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5      f bDevExpress.Xpf.Grid.v16.2.Core, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   6W   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  6�   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6�   -   5        $	��510��5      $	��900��6,   .��5	      �   � RowDefinitions  5
   
   �� 5      $	��99* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   .+�5   
   %  DevExpress.Xpf.Grid.GridControl  -   5          Name$ gridSach��5      )  #DevExpress.Xpf.Grid.DataControlBase   AutoGenerateColumns$ AddNew=�6,   $��0��6I   #   EnableSmartColumnsGeneration . $��Stretch=�6z   $��Stretch=�6�      View 5      #  DevExpress.Xpf.Grid.TableView  5         AllowPerPixelScrolling . &   DevExpress.Xpf.Grid.DataViewBase   ShowTotalSummary .    FormatConditions 5      )  #DevExpress.Xpf.Grid.FormatCondition  5      -  'DevExpress.Xpf.Grid.FormatConditionBase   
Expression$# [LuongDaMuon] >= [TongSoSach]��6.   	   	FieldName$	 TenSach��5   .   1  +DevExpress.Xpf.Grid.ExpressionConditionBase
   Format.
 5      6  0DevExpress.Xpf.Grid.ConditionalFormatting.Format  6	  0DevExpress.Xpf.Core.ConditionalFormatting.Format 	  
Background �	#FFECDA6C 	  
FontWeight$
 Bold"�5   !    	  TextDecorations 5   !   Z� 5      5      5      � 5   
   $��Stretch=�6   $��Stretch=�6,   $��2��6J   $��	150,0,0,0q�6W    � ColumnDefinitions 5       �� 5!      $	��10* �6#   �� 5"      $	��20* �6#   �� 5#      $	��10* �6#   �� 5$      $	��20* �6#   �� 5%      $	��10* �6#   �� 5&      $	��20* �6#   �� 5'      $
��Auto �6#     5)      �� 5*      �� 5+      $��49.667 �6    �� 5,      .+�5.      �� -   5         ��Name$ label��5.      $��Tên Sách :��6#   $
��Left=�68   $��0,14,0,0q�6S   $	��Top=�6e   $��58��6}   $��1��6�   �� 5/      -   5        $ label1��5/      $��Năm Xuất Bản:��6$   $
��Left=�6<   $��0,14.333,0,0q�6W   $	��Top=�6m   $��88��6�   $��2��6�   �� 50      -   5        $ label2��50      $��Số Trang:��6$   $
��Left=�68   $��0,13,0,0q�6S   $	��Top=�6e    J� RenderTransformOrigin$ -0.107,0.273&�6}   $��1��6�   $��2��6�   �� 51      -   5        $ label3��51      $��Số Lượng Sách��6$   $��	0,24,26,0q�6<   $	��Top=�6O   $��2��6g   $��Stretch=�6w   $��Stretch=�6�   �� 52      -   5        $ label4��52      $��
Tác Giả��6$   $
��Left=�66   $��0,17.333,0,0q�6Q   $	��Top=�6g   $��2��6   $��4��6�   �� 53      -   5        $ label5��53      $��Nhà Xuất bản��6$   $
��Left=�6;   $��0,11,0,0q�6V   $	��Top=�6h   $��4��6�   �� 54      -	   5        $ label6��54      $��Thể Loại:��6$   $
��Left=�68   $��0,13,0,0q�6S   $	��Top=�6e   $��1��6}   $��4��6�   �� 55      -
   5         ��Name$ 
_cbbtacgia��55      $
��Left=�6+   $��0,17.333,0,0q�6F   $	��Top=�6\   $	��120��6t   $��2��6�   $��5��6�   �� 56      -   5        $ _cbbnxb��56      $
��Left=�6(   $��4,11,0,0q�6C   $	��Top=�6U   $	��120��6m   $��5��6y   �� 57      -   5        $ _cbbtheloai��57      $
��Left=�6,   $��4,14,0,0q�6G   $	��Top=�6Y   $	��120��6q   $��1��6}   $��5��6�   �� 58      -   5        $ label7��58      $��	Mã Sách��6$   $
��Left=�66   $��0,18,0,0q�6Q   $	��Top=�6c   �� 59      -   5        $ label8��59      $��Sách đã mượn:��6$   $
��Left=�6<   $��0,17.333,0,0q�6W   $	��Top=�6m   $��2��6�   $��2��6�   �� 5:      -   5         ��Name$ _txtsachdamuon��5:      $
��Left=�6.   $��23��6I   $��23,13.333,0,0q�6U    �� TextWrapping$
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��120��6�   {�.  $��2��6�   $��3��6�   � 5;      $
��Left=�6   $	��149��6.   $	��Top=�6;   $	��182��6S   $��0,0,0,0q�6_   $��3��6p   $��1��6�   .+�5<      %
  DevExpress.Xpf.Editors.TextEdit
  -   5         
 Name$ 
_txtmasach��5<      $��
0,24,-24,0q�63   $	��Top=�6G   $	��150��6_    
  Mask$ [a-zA-Z0-9]+��6k    
  MaskType$ RegEx=�6   %  DevExpress.Xpf.Editors.BaseEdit   
IsReadOnly . $
��Left=�6�   $��Stretch=�6�   
  5=      -   5        $ _txttensach��5=      $
��Left=�65   $��0,70,0,0q�6P   $	��Top=�6b   $	��150��6z   $
 None=�6�    6�   Z� 6�   %  DevExpress.Xpf.Editors.DateEdit  5>      -   5          Name$ 	_txtnamxb��5>      $
��Left=�62   $��	0,120,0,0q�6M   $	��Top=�6`   $	��150��6x   5?      � 5@      $
��Left=�6   $	��110��6.   $	��Top=�6;   $	��121��6S   $��22,0,0,0q�6_   $��3��6q   $��3��6�   .+�5A      
  -   5        $ 
_txtsoluog��5A      $
��Left=�63   $��0,22,0,0q�6N   $	��Top=�6`   $	��119��6x   $ n0��6�   $ Numeric=�6�   
  5B      -   5        $ _txtsotrang��5B      $
��Left=�64   $��0,76,0,0q�6O   $	��Top=�6a   $	��121��6y   $ n0��6�   $ Numeric=�6�   5C      5D      � 5E   
   $��Stretch=�6   $��Stretch=�6.   $��1��6K    5F      �� 5G      $
��106* �6#   �� 5H      $
��106* �6#   �� 5I      $
��106* �6#   �� 5J      $
��106* �6#   �� 5K      $
��160* �6#   �� 5L      $
��106* �6#   �� 5M      $
��106* �6#   �� 5N      $	��98* �6#   .+�5P      �� -   5         ��Name$ _btncancel_add��5P      $��Cancel��6-   $��6��6>   $
��Left=�6N   $��6,11,0,0q�6i   $	��Top=�6{   $��75��6�   {�.  6�   �� 5Q      -   5        $ 
_txtsearch��5Q      $��4��6*   $
��Left=�6:   $��23��6U   $��	35,11,0,0q�6a   $
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��120��6�   &   DevExpress.Xpf.Core.SimpleButton  5R      -   5          Name$ _btnadd��5R      $��Add new��6/   $��Stretch=�6A   $��Stretch=�6_   $��10,7,0,0q�6{      Glyph 6�   *  $DevExpress.Xpf.Core.DXImageExtension     Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$ Apply_16x16.png   5S      -   5        $ _btnedit��5S      $
��Edit��60   $��Stretch=�6?   $��15,6,0,0q�6^   $��Stretch=�6p   $��1��6�    6�     $ ClearTableStyle_16x16.png 6�     5T      -   5        $ 
_btndelete��5T      $��Delete��62   $��Stretch=�6C   $��10,7,0,0q�6a   $��Stretch=�6s   $��2��6�    6�     $ Close_16x16.png 6�     5U      -   5        $ _btnrefresh��5U      $��Refresh��63   $��Stretch=�6E   $��16,7,0,0q�6c   $��Stretch=�6u   $ 1.721,0.458&�6�   $��3��6�    6�     $ Convert_16x16.png 6�     5V      -   5        $ 
_btnsearch��5V      $��Search��62   $��Stretch=�6C   $��4,6,0,0q�6b   $��Stretch=�6s   $ 0.298,0.842&�6�   $��5��6�   $] Wpack://application:,,,/DevExpress.Images.v16.2;component/DevAV/Actions/Search_16x16.png��6�   5X      &   DevExpress.Xpf.Editors.ImageEdit  5Y   
   -   5          Name$ _imagebooks��5Y      $
��Left=�6-   $��0,15,0,0q�6H   $��2��6Z   $	��Top=�6g   $	��150��6   $	��150��6�   $	��150��6�   $	��150��6�   5Z      5[      