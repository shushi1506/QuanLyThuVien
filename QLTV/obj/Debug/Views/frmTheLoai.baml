   M S B A M L   `   `   `  ����?  ;QLTV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QLTV.Views
QLTV.Views  5          QLTV.Views.frmTheLoai   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:QLTV.Views     5      a ]DevExpress.Xpf.Grid.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aGdxgt<http://schemas.devexpress.com/winfx/2008/xaml/grid/themekeys  5      f bDevExpress.Xpf.Grid.v16.2.Core, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6M   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  6�   $	��500��5
      $	��900��6#     � 	Resources  5      ,  &DevExpress.Xpf.Core.ImageDataConverter  5   
      KeyImageDataConverter  6    .��5      �   5   
     DetailCoreTemplate-  'DevExpress.Xpf.Core.MeasurePixelSnapper � ColumnDefinitions � RowDefinitions  rowWithToolTipTemplate ^� 	IsEnabled �� Path ^� InitialShowDelay ^� ToolTip
 � Tag��%  &	       &	 �    �� 5      .R�5        $	��300��6)   $	��300��68   ._�5      �  5      �� 5      �� 5       5      �� 5      �� 5      .+�5      �� $��0��6$   $��0��64   $��Mã Thể Loại:��6A   �� 5      $��0��6$   $��1��64   $��Tên Thể Loại:��6A   �� 5      $��1��6$   $��0��64   ��6A   �� *Row.MaTheLoai+�� 5      $��1��6$   $��1��64   ��6A   �� *Row.TenTheLoai+5       5!      5"      �� 5#      .R�5$      �� ��6#   �� ��67   �� *View.DefaultDataRowTemplate+ 5%      �� 5&      $ DataContext.Tooltip�6"   $ 10��5(   Z    5)      �� 5*      #���  6=   $ Transparent��6t   $	��600��6�   ��6)   �� 6�   5,      5-      5.      .+�5/   
   %  DevExpress.Xpf.Grid.GridControl  -   5          Name$ gridTheLoai��5/      )  #DevExpress.Xpf.Grid.DataControlBase	   AutoGenerateColumns$	 AddNew=�6/   #
   EnableSmartColumnsGeneration
 . $��0,0,358,332q�6p      View 50      #  DevExpress.Xpf.Grid.TableView  52         DataRowTemplate# [ 6       UseLightweightTemplates$
 NoneX�6Z      AllowPerPixelScrolling . &   DevExpress.Xpf.Grid.DataViewBase   ShowTotalSummary .    NavigationStyle$	 Row=�6�      AllowScrollAnimation . &   DevExpress.Xpf.Grid.GridViewBase   ShowGroupedColumns . 5N      5P        5Q   
   -   5        $ gridNXB��5Q      $	 AddNew=�6+   
 . $
��Left=�6l   $��358,173,0,0q�6�   $	��Top=�6�   $	��180��6�   $	��542��6�    5R        5S       .  . 6>   5U        5V   
   -   5        $ 
gridTacGia��5V      $	 AddNew=�6.   
 . $
��Left=�6o   $��	0,358,0,0q�6�   $	��Top=�6�   $	��142��6�   $	��542��6�    5W        5X       .  . 6>   5Z      &   DevExpress.Xpf.Core.SimpleButton  5[   
   -   5          Name$ 	_btnaddTL��5[      $��Add new��6-   $
��Left=�6?   $��26��6Z   $��	549,0,0,0q�6f   $	��Top=�6y   $��90��6�   6�     5\   
   -   5        $ 
_btnsaveTL��5\      $
��Edit��6.   $
��Left=�6=   $��26��6X   $��	658,0,0,0q�6d   $	��Top=�6w   $��90��6�   6�     5]   
   -   5        $ _btndeleteTL��5]      $��Delete��60   $
��Left=�6A   $��26��6\   $��	764,0,0,0q�6h   $	��Top=�6{   $��90��6�     5^   
   -   5        $ 
_btnloadTL��5^      $
��Load��6.   $
��Left=�6=   $	��168��6X   $��	857,0,0,0q�6e   $	��Top=�6x   $��43��6�   6�     5_   
   -   5        $ 	_btnaddTG��5_      $��Add new��6-   $
��Left=�6?   $��29��6Z   $��547,471,0,0q�6f   $	��Top=�6{   $��77��6�     5`   
   -	   5        $ _btndeleteTG��5`      $��Delete��60   $
��Left=�6A   $��29��6\   $��760,471,0,0q�6h   $	��Top=�6}    J� RenderTransformOrigin$ 0.548,0.414&�6�   $��77��6�     5a   
   -
   5        $ 
_btnsaveTG��5a      $
��Edit��6.   $
��Left=�6=   $��29��6X   $��656,471,0,0q�6d   $	��Top=�6y   $��77��6�     5b   
   -   5        $ 
_btnloadTG��5b      $
��Load��6.   $
��Left=�6=   $��42��6X   $��807,405,-49,0q�6d   $	��Top=�6{   $	��142��6�   $ 0.5,0.5&�6�   z�5c      V� 5d      .~�5e      �� �� 5f      �� 5g       �� Angle$ -90.648Q�6&   T� 5h      5i      5k        5l   
   -   5        $ 
_btnaddNXB��5l      $��Add new��6.   $
��Left=�6@   $��50��6[   $��	0,173,0,0q�6g   $	��Top=�6z   $��59��6�   6�     5m   
   -   5        $ _btnsaveNXB��5m      $
��Edit��6/   $
��Left=�6>   $��50��6Y   $��	0,228,0,0q�6e   $	��Top=�6x   $��59��6�   6�     5n   
   -   5        $ _btnloadNXB��5n      $
��Load��6/   $
��Left=�6>   $��50��6Y   $��
92,228,0,0q�6e   $	��Top=�6y   6�     5o   
   -   5        $ _btndeleteNXB��5o      $��Delete��61   $
��Left=�6B   $��51��6]   $��	0,283,0,0q�6i   $	��Top=�6|   $��59��6�   6�   �� 5p   
   -   5         ��Name$ _txttentheloai��5p      $
��Auto=�6*   $��23��6\   $��658,114,122,0q�6h    �� TextWrapping$
 Wrap=�6   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5q   
   -   5         ��Name$ label��5q      $��Mã Thế Loại��6   $
��Left=�65   $��
581,70,0,0q�6P   $	��Top=�6d   �� 5r   
   -   5        $ label1��5r      $��Tên Thể Loại��6    $
��Left=�67   $��787,115,0,0q�6R   $	��Top=�6g   �� 5s   
   -   5        $ label2��5s      $��Mã NXB��6    $
��Left=�61   $��166,220,0,0q�6L   $	��Top=�6a   �� 5t   
   -   5        $ label3��5t      $��Tên NXB��6    $
��Left=�62   $��165,269,0,0q�6M   $	��Top=�6b   �� 5u   
   -   5        $ label4��5u      $��Tên Tác Giả��6    $
��Left=�66   $��558,418,0,0q�6Q   $	��Top=�6f   �� 5v   
   -   5        $ label5��5v      $��Mã Tác Giả��6    $
��Left=�65   $��777,383,0,0q�6P   $	��Top=�6e   �� 5w   
   -   5        $ 
_txttennxb��5w      $
��Left=�6&   $��23��6A   $��224,267,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5x   
   -   5        $ _txttentacgia��5x      ��. $
��Left=�6N   $��23��6i   $��629,416,0,0q�6u   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�     5y   
   -   5        $ _btnaddTL_cancel��5y      $��Cancel��64   $
��Left=�6E   $��23��6`   $��
549,42,0,0q�6l   $	��Top=�6�   $��93��6�   $y�Hidden=�6�   {�.  6�     5z   
   -   5        $ _btnaddNXB_cancel��5z      $��Cancel��65   $
��Left=�6F   $��50��6a   $��
53,173,0,0q�6m   $	��Top=�6�   $��38��6�   $ -0.105,0.447&�6�   $y�Hidden=�6�   {�.  6�     5{   
   -   5        $ _btnaddTG_cancel��5{      $��Cancel��64   $
��Left=�6E   $��26��6`   $��547,443,0,0q�6l   $	��Top=�6�   $��69��6�   {�.  $y�Hidden=�6�   6�   %	  DevExpress.Xpf.Editors.TextEdit	  5}   
   -   5         	 Name$ _txtmatheloai��5}      $
��Left=�6.   $��
656,70,0,0q�6I   $	��Top=�6]   $	��120��6u    	  Mask$ 	[a-zA-Z]+��6�    	  MaskType$ RegEx=�6�   	  5~   
   -   5        $ 	_txtmanxb��5~      $
��Left=�6+   $��224,220,0,0q�6F   $	��Top=�6[   $	��120��6s   $ 	[a-zA-Z]+��6   $ RegEx=�6�   	  5   
   -   5        $ _txtmatacgia��5      $
��Left=�6-   $��629,383,0,0q�6H   $	��Top=�6]   $	��120��6u   $
 None=�6�   ��.  6�   Z� 6�   5�      5�      