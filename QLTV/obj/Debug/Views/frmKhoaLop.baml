   M S B A M L   `   `   `  ����?  ;QLTV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QLTV.Views
QLTV.Views  5          QLTV.Views.frmKhoaLop   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:QLTV.Views     5      f bDevExpress.Xpf.Grid.v16.2.Core, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6M   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  6�   .��5
      � .+�5   
   %  DevExpress.Xpf.Grid.GridControl  -   5           Name$  gridkhoa��5      )  #DevExpress.Xpf.Grid.DataControlBase   AutoGenerateColumns$ AddNew=�6,   #   EnableSmartColumnsGeneration . $
��Left=�6m   $	��Top=�6�   $	��231��6�   $	��359��6�      View 5      #  DevExpress.Xpf.Grid.TableView  5         AllowPerPixelScrolling . &   DevExpress.Xpf.Grid.DataViewBase   ShowTotalSummary . 6>   5        5   
   -   5        $  gridlop��5      $ AddNew=�6+    . $
��Left=�6l   $��	0,256,0,0q�6�   $	��Top=�6�   $	��244��6�   $	��359��6�    5        5       .  . 6>   5      &   DevExpress.Xpf.Core.SimpleButton  5   
   -   5          Name$ _btnaddK��5      $��Add new��6,   $
��Left=�6>   $��30��6Y   $��
393,59,0,0q�6e   $	��Top=�6y   $��95��6�      GlyphAlignment$ Right=�6�      Glyph 6�   *  $DevExpress.Xpf.Core.DXImageExtension  	   Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$	 Add_16x16.png 6�     5   
   -   5        $ 	_btnsaveK��5      $
��Edit��6-   $
��Left=�6<   $��30��6W   $��
517,59,0,0q�6c   $	��Top=�6w   $��93��6�    6�     $	 EditName_16x16.png   5   
   -   5        $ _btnaddL��5      $��Add new��6,   $
��Left=�6>   $��30��6Y   $��393,309,0,0q�6e   $	��Top=�6z   $��93��6�   $ Right=�6�    6�     $	 Add_16x16.png   5   
   -   5        $ 	_btnloadL��5      $
��Load��6-   $
��Left=�6<   $��30��6W   $��517,423,0,0q�6c   $	��Top=�6x   $��93��6�    6�     $	 Refresh_16x16.png   5   
   -   5        $ 	_btnloadK��5      $
��Load��6-   $
��Left=�6<   $��30��6W   $��393,170,0,0q�6c   $	��Top=�6x   $��95��6�    6�     $	 Refresh_16x16.png   5   
   -   5        $ _btnaddK_cancel��5      $��Cancel��63   $
��Left=�6D   $��32��6_   $��393,104,0,0q�6k   $	��Top=�6�   $��95��6�   $ Right=�6�    6�     $	 Cancel_16x16.png 5        5   
   -	   5        $ _btndeleteK��5      $��Delete��6/   $��30��6@   $��517,170,288,300q�6L   $ Right=�6�    6     $	 DeleteList_16x16.png 6�     5    
   -
   5        $ _btndeleteL��5       $��Delete��6/   $
��Left=�6@   $��30��6[   $��393,423,0,0q�6g   $	��Top=�6|   $��93��6�   $ Right=�6�    6�     $	 ClearTableStyle_16x16.png 6�     5!   
   -   5        $ 	_btnsaveL��5!      $
��Edit��6-   $
��Left=�6<   $��30��6W   $��517,309,0,0q�6c   $	��Top=�6x   $��93��6�    6�     $	 SaveTheme_16x16.png   5"   
   -   5        $ _btnaddL_cancel��5"      $��Cancel��63   $
��Left=�6D   $��30��6_   $��393,357,0,0q�6k   $	��Top=�6�   $��93��6�   $ Right=�6�    6�     $	 Cancel_16x16.png %  DevExpress.Xpf.Editors.TextEdit  5$   
   -   5        
  Name$
 
_txtmakhoa��5$      $
��Left=�6+   $��
718,63,0,0q�6F   $	��Top=�6Z   $	��150��6r      Mask$ 	[a-zA-Z]+��6~      MaskType$ RegEx=�6�     5%   
   -   5        $
 _txttenkhoa��5%      $
��Left=�6,   $��718,170,0,0q�6G   $	��Top=�6\   $	��150��6t     5&   
   -   5        $
 
_txttenlop��5&      $
��Left=�6+   $��718,423,0,0q�6F   $	��Top=�6[   $	��150��6s     5'   
   -   5        $
 	_txtmalop��5'      $
��Left=�6*   $��718,318,0,0q�6E   $	��Top=�6Z   $	��150��6r   $
 None=�6�    6~   Z� 6�   �� 5(   
   -   5         ��Name$ label��5(      $��Mã Khoa��6   $
��Left=�61   $��
640,61,0,0q�6L   $	��Top=�6`   �� 5)   
   -   5        $ label1��5)      $��	Tên Khoa��6    $
��Left=�63   $��640,169,0,0q�6N   $	��Top=�6c   �� 5*   
   -   5        $ label2��5*      $��
Tên Lớp��6    $
��Left=�62   $��640,424,0,0q�6M   $	��Top=�6b   �� 5+   
   -   5        $ label3��5+      $��	Mã Lớp��6    $
��Left=�61   $��640,318,0,0q�6L   $	��Top=�6a   5-      5.      