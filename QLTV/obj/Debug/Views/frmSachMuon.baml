   M S B A M L   `   `   `  ����?  ;QLTV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QLTV.Views
QLTV.Views  5          QLTV.Views.frmSachMuon   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:QLTV.Views     5      f bDevExpress.Xpf.Grid.v16.2.Core, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5      j fDevExpress.Xpf.LayoutControl.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  6M   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  6�   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6�   $	��918��5	      $	��500��6"   .��5
      � $
��Left=�6   $	��962��6&     � ColumnDefinitions  5   
   �� 5      $
��493* �6   �� 5      $	��5.5 �6   �� 5      $
��463* �6   .+�5   
   � $��Stretch=�6   $	��500��6-   $��0,0,0,0q�6:   $	��Top=�6K   $��2��6c    � RowDefinitions 5      �� 5      $
��151* �6    �� 5      $	��99* �6    .+�5      � $��Stretch=�6   $	��305��61   $	��Top=�6>   $	��463��6V   $��0,0,0,0q�6b   $
��Auto=�6s   $��2��6�   .+�5      �� -   5         ��Name$ 
_txtmamuon��5      $
��Left=�6.   $��23��6I   $��	94,17,0,0q�6U    �� TextWrapping$
 Wrap=�6h   $	��Top=�6}   $	��120��6�   $ �� HorizontalScrollBarVisibility$
 Auto=�6�   �� 5      -   5         ��Name$ label1��5      $��Mã Mượn��6(   $
��Left=�6:   $��	26,18,0,0q�6U   $	��Top=�6h   �� 5      -   5        $ label2��5      $��Tên Độc Giả��6(   $
��Left=�6>   $��9,68,0,0q�6Y   $	��Top=�6k   �� 5      -   5        $ label3��5      $��
Tên Sách��6(   $
��Left=�6;   $��
26,121,0,0q�6V   $	��Top=�6j   �� 5      -   5        $ label4��5      $��Ngày Mượn��6(   $
��Left=�6<   $��
26,176,0,0q�6W   $	��Top=�6k   �� 5      -   5        $ label5��5      $��Ngày Trả��6(   $
��Left=�6;   $��
271,27,0,0q�6V   $	��Top=�6j   �� 5      -   5        $ label6��5      $
��Left=�6(   $��
271,78,0,0q�6C   $	��Top=�6W   �� 5      -   5        $ label7��5      $��Tiền Cọc��6(   $
��Left=�6;   $��271,121,0,0q�6V   $	��Top=�6k   �� 5      -	   5        $ label8��5      $��Số Lượng Mượn��6(   $
��Left=�6@   $��233,176,0,0q�6[   $	��Top=�6p   �� 5       -
   5         ��Name$ _cbbtendocgia��5       $
��Left=�62   $��	94,66,0,0q�6M   $	��Top=�6`   $	��120��6x   �� 5!      -   5        $ _cbbtensach��5!      $
��Left=�60   $��
94,121,0,0q�6K   $	��Top=�6_   $	��120��6w   �� 5"      -   5         ��Name$ _checkdatra��5"      $��
Đã Trả��60   $
��Left=�6A   $��
343,72,0,0q�6\   $	��Top=�6p   $��73��6�   %  DevExpress.Xpf.Editors.DateEdit  5#      -   5          Name$ 	_datemuon��5#      $
��Left=�62   $��
94,176,0,0q�6M   $	��Top=�6a   $	��117��6y     5$      -   5        $ _datetra��5$      $
��Left=�61   $��
343,27,0,0q�6L   $	��Top=�6`   $	��120��6x   �� 5%      -   5        	 ��Name$	 _btnadd_cancel��5%      $��Cancel��61   $
��Left=�6B   $��
23,273,0,0q�6]   $	��Top=�6q   $��75��6�   {�.  6�   &   DevExpress.Xpf.Core.SimpleButton  5&      -   5        
  Name$
 _btnadd��5&   "   $��Add new��63   $
��Left=�6E   $��31��6`   $��
17,237,0,0q�6l   $	��Top=�6�   $��90��6�      Glyph 6�   *  $DevExpress.Xpf.Core.DXImageExtension     Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$ Apply_32x32.png   5'      -   5        $
 _btnsave��5'   "   $
��Edit��64   $
��Left=�6C   $��31��6^   $��151,237,0,0q�6j   $	��Top=�6   $��90��6�    6�     $ Clear_32x32.png   5(      -   5        $
 
_btndelete��5(   "   $��Delete��66   $
��Left=�6G   $��31��6b   $��270,237,0,0q�6n   $	��Top=�6�   $��90��6�    6�     $ Close_32x32.png   5)      -   5        $
 _btnload��5)   "   $
��Load��64   $
��Left=�6C   $��31��6^   $��378,237,0,0q�6j   $	��Top=�6    J� RenderTransformOrigin$ 0.062,-1.095&�6�   $��88��6�    6�     $ Convert_32x32.png %  DevExpress.Xpf.Editors.TextEdit  5*      -   5          Name$ _txttiencoc��5*      $
��Left=�64   $��343,125,0,0q�6O   $	��Top=�6d   $	��120��6|      Mask$ c0��6�      MaskType$ Numeric=�6�     5+      -   5        $ _txtsoluongmuon��5+      $
��Left=�68   $��343,174,0,0q�6S   $	��Top=�6h   $	��117��6�   $ n0��6�   $ Numeric=�6�   5,      � 5-      $	��195��6   $��Stretch=�6    $��0,0,0,0q�6>   $	��Top=�6O   $
��Auto=�6g   $��1��6�   .+�5.      �� -   5        $ 	_txttendg��5.      $
��Left=�6-   $��23��6H   $��	70,33,0,0q�6T   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   ��. 6�   �� 5/      -   5        $ _txtdiachidg��5/      $
��Left=�60   $��23��6K   $��	70,84,0,0q�6W   $
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��120��6�   $
 Auto=�6�   �� 50      -   5        $ 	_txtlopdg��50      $
��Left=�6-   $��23��6H   $��
288,33,0,0q�6T   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��120��6�   $
 Auto=�6�   �� 51      -   5        $ 
_txtkhoadg��51      $
��Left=�6.   $��23��6I   $��
288,91,0,0q�6U   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��120��6�   $
 Auto=�6�   �� 52      -   5        $ _txttienkiguidg��52      $
��Left=�63   $��23��6N   $��
70,141,0,0q�6Z   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��120��6�   53      54      � 55   
   $��Stretch=�6   $	��500��6-   $	��Top=�6:   $
��Auto��6R   $��0��6_    56      �� 57      $
��101* �6    �� 58      $
��149* �6    .+�5;      %  DevExpress.Xpf.Grid.GridControl  -   5          Name$ gridSachMuon��5;      $��0��64   $��Stretch=�6A   )  #DevExpress.Xpf.Grid.DataControlBase   AutoGenerateColumns$ AddNew=�6_   #   EnableSmartColumnsGeneration . $��0,0,0,0q�6�      View 5<      #  DevExpress.Xpf.Grid.TableView  5=         AllowPerPixelScrolling . &	   DevExpress.Xpf.Grid.DataViewBase 	  ShowTotalSummary .  	  AllowEditing .  (   !AllowConditionalFormattingManager . %   AllowConditionalFormattingMenu .    FormatConditions 5?      0
  *DevExpress.Xpf.Grid.DataBarFormatCondition
  5A      -  'DevExpress.Xpf.Grid.FormatConditionBase   	FieldName$ SoLuongMuon��69      PredefinedFormatName$ BlueGradientDataBar��6Q   )  #DevExpress.Xpf.Grid.FormatCondition  5B         
Expression$ [DaTra] = False��62   $ 	TenDocGia��5C   .   1  +DevExpress.Xpf.Grid.ExpressionConditionBase   Format. 5D   "   6  0DevExpress.Xpf.Grid.ConditionalFormatting.Format  6  0DevExpress.Xpf.Core.ConditionalFormatting.Format   
Background �	#FFF5BEF0    
FontWeight$
  Bold"�5F   !   !   TextDecorations! 5G   !   Z� 5H        5I      $ [NgayHen] < Today()��62   $ MaMuon��5J   .   $ RedText��5K   1   . 5L   "      �	#FFF1A173$
  Bold"�5N   !   ! 5O   !   Z� 5P      5R      5T        5U      -   5        $ 
gridDocgia��5U      $��1��62   $��Stretch=�6?   $ AddNew=�6]    . $��0,0,0,0q�6�   $	��Top=�6�   $	��289��6�    5V        5W       .  . 6B   5Y      5Z      �� 5[   
   -   5        " ��Name$" gridSplitter��5[      $��1��6-   $��Stretch=�6=   $��0,0,0,0q�6[   $��Stretch=�6l   $��5��6�   
���   �6�   5c      5d      