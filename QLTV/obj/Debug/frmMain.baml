   M S B A M L   `   `   `  ����?  ;QLTV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QLTVQLTV  5   	       QLTV.frmMain   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _DevExpress.Xpf.NavBar.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxnb4http://schemas.devexpress.com/winfx/2008/xaml/navbar  5      c _DevExpress.Xpf.Charts.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxc4http://schemas.devexpress.com/winfx/2008/xaml/charts  5      localclr-namespace:QLTV  5   	   e aDevExpress.Xpf.Carousel.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxca6http://schemas.devexpress.com/winfx/2008/xaml/carousel  5	   	   c	 _DevExpress.Xpf.Ribbon.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon 	 6M   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6�   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  6�   TCustomGhttp://schemas.devexpress.com/winfx/2008/xaml/charts/rangecontrolclient  6  ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  6b  e
 aDevExpress.Xpf.Printing.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aBdxp6http://schemas.devexpress.com/winfx/2008/xaml/printing  
 6�  f bDevExpress.Xpf.Grid.v16.2.Core, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   6�  d `DevExpress.Xpf.Docking.v16.2, Version=16.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxdo5http://schemas.devexpress.com/winfx/2008/xaml/docking  6&    � Title$  Quan Ly Thu Vien��5   	   $��631.5��6"   $
��1368��61    � WindowStyle$ ThreeDBorderWindow=�6>    � WindowState$ 	Maximized=�6_   .��5      �  � RowDefinitions 5   
   �� 5      $
��557* �6   �� 5      $	��45* �6    � ColumnDefinitions 5   
   �� 5      $��1084* �6   �� 5      $
��277* �6   .+�5   
   ) 	 #DevExpress.Xpf.Ribbon.RibbonControl  $	��144��6      RibbonStyle$ 
Office2010=�6)      AllowMinimizeRibbon .    ToolbarShowMode$
 Hide=�6]      ShowApplicationButton .  #	   MinimizationButtonVisibility$
	 Auto=�6�   
   PageCategoryAlignment$
 Right=�6�   $��	0,0,153,0q�6�      
Categories. 5      5 	 /DevExpress.Xpf.Ribbon.RibbonDefaultPageCategory  2 	 ,DevExpress.Xpf.Ribbon.RibbonPageCategoryBase   Caption$ defaultCategory��6,      Pages. 5      & 	  DevExpress.Xpf.Ribbon.RibbonPage     Caption)  #DevExpress.Xpf.Core.ObjectConverter$ 
Quản Lý 6!      Groups. 5      + 	 %DevExpress.Xpf.Ribbon.RibbonPageGroup  -   5          Name$ _rpgsach��5   A      Caption$ Quản Lý Sách��6*      Items. 5      '  !DevExpress.Xpf.Bars.BarButtonItem  -   5          Name$ _btntheloai��5   V   !  DevExpress.Xpf.Bars.BarItem   Content$ Loại Sách   6,      RibbonStyle$ Large=�6B      Glyph 6�   *	  $DevExpress.Xpf.Core.DXImageExtension	   	  Image1
  +DevExpress.Xpf.Core.Native.DXImageConverter$ BOReport_16x16.png
    
LargeGlyph 6�   	  $ BOReport_32x32.png
   5      -   5        $ _btnkhosach��5   U   $ Kho Sách   6,   $ Large=�6A    6�   	  $ ConvertToRange_16x16.png
  6�   	  $ ConvertToRange_32x32.png
 5        5      -   5        $ _rpgnguoimuon��5   G   $! Quản Lý Người Mượn��6*   . 5         -   5        $ 
_bbidocgia��5    ,   $ Độc giả  6@   $ Large=�6S    6�   	  $ BODepartment_16x16.png
  6�   	  $ BODepartment_32x32.png
   5!      -   5        $ _bbikhoalop��5!   ,   $ Khoa Lớp   6A   $ Large=�6V    6�   4  .DevExpress.Xpf.Core.DXImageOffice2013Extension     Image;  5DevExpress.Xpf.Core.Native.DXImageOffice2013Converter$ UserGroup_16x16.png  6�     $ UserGroup_32x32.png 5$        5%      -   5        $ _rpgmuontra��5%   E   $ Quản Lý Mượn Trả��6*   . 5&        -   5        $ _bbisachdamuon��5&   ,   $ Sách Đã Mượn 6D   $ Large=�6[    6�   	  $ BOOrder_16x16.png
  6�   	  $ BOOrder_32x32.png
 5'        5(      -	   5        $ _rpgthongke��5(   =   $ Thống Kê��6*   . 5)        -
   5        $ _bbisachmuon��5)   ,   $ Sách Mượn 6B   $ Large=�6V    6�   	  $ Financial_32x32.png
  6�   	  $ Financial_32x32.png
   5*      -   5        $ _bbidocgiareport��5*   ,   $ Đọc Giả 6F   $ Large=�6X    6l   	  $ BOPerson_32x32.png
  6�   	  $ BOPerson_32x32.png
 6�   5,      5-        5.      $
 Home 6!   . 5/        -   5        $ _rpguser��5/   *   $ Chương Trình��6<      ShowCaptionButton .     IsCaptionButtonEnabled .    Glyph 6�   	  $ Add_32x32.png
 . 50        -   5        $ _bbirestart��50   ,   $ Restart 6A      BarItemDisplayMode$ ContentAndGlyph=�6S   $ Large=�6�    6x   	  $ Refresh_16x16.png
  6�   	  $ Add_32x32.png
 6�     51      -   5        $ _bbiadduser��51   ,   $ Quan Ly Người Dùng 6A   $ ContentAndGlyph=�6^   $ Large=�6�    6�   	  $ BOCustomer_16x16.png
  6�   	  $ BOCustomer_32x32.png
 6�   52      55      56      57      )  #DevExpress.Xpf.NavBar.NavBarControl  58   
   $
��Left=�6   $��	0,139,0,0q�68   $	��Top=�6K   $	��124��6c   $��2��6o      Groups. 59      '  !DevExpress.Xpf.NavBar.NavBarGroup  -   5          Name$ _navsachgroup��59          Header$  Sách 66   !   DisplayMode$! ImageAndText=�6D   "   ImageSource" 6_   	  $ BOChangeHistory_32x32.png
 #   Items.# 5:      &   DevExpress.Xpf.NavBar.NavBarItem  -   5        $  Name$$ _navsach��5:   "   %   Content$% Sách 64   &   ImageSource& 6C   	  $ Reading_32x32.png
 6v     5;      -   5        $$ _navtheloai��5;   "   $% Thể Loại 67   '   DisplayMode$' Default=�6{   & 6J   	  $ Feeds_32x32.png
 6�     5<      -   5        $$ 
_navtacgia��5<   "   $% 
Tác Giả 66   & 6H   	  $ BOEmployee_32x32.png
 6~     5=      -   5        $$ _navnxb��5=   "   $% Nhà Xuất Bản 63   & 6J   	  $ BOContact2_32x32.png
 6�   5?        5@      -   5        $ _navngoidunggroup��5@      $  Người Đọc 6:   " 6M   	  $ Show_32x32.png
 .# 5A        -   5        $$ 
_navdocgia��5A   "   $% Đọc giả 66   & 6H   	  $% ConditionalFormatting_32x32.png
 6�     5B      -   5        $$ _navlop��5B   "   $% Lớp 63   & 6A   	  $ Team_32x32.png
 6q     5C      -   5        $$ _navkhoa��5C   "   $
% Khoa 64   & 6C   	  $ BOPosition2_32x32.png
 6z   5D        5E      -   5        $ _navusergroup��5E      $
  User 66   " 6D   	  $&  AllowUsersToEditRanges_32x32.png
 .# 5F        -   5        $$ _navnguoidung��5F   "   $% Người Dùng 69   & 6N   	  $ BOCustomer_32x32.png
 6�   5G        5H      -   5        $ _navsachmuongroup��5H      $  	Sach Muon 6:   " 6M   	  $ NewTableStyle_32x32.png
 .# 5I        -   5        $$ _navsachmuon��5I   "   $% Sách Mượn 68   & 6L   	  $ BOOrder_32x32.png
 6   5J      5K      8  2DevExpress.Xpf.Editors.DateNavigator.DateNavigator  5L   
   -   5        (  Name$( datenavi��5L      $��Stretch=�6.   $��0,0,0,0q�6L   $��Stretch=�6]   $��1��6�   $��0��6�   5N      .  (DevExpress.Xpf.Docking.DockLayoutManager  5O   
   -   5        )  Name$) 
docklayout��5O   !   *   FloatingMode$* Desktop=�65   $
��Left=�6L   $	��948��6g   $��124,144,0,0q�6s   $��2��6�   +   
LayoutRoot.+ 5P      (  "DevExpress.Xpf.Docking.LayoutGroup  +  %DevExpress.Xpf.Docking.BaseLayoutItem,   Caption$, 
LayoutRoot��6   -   Items.- 5Q        .   Orientation$. Vertical=�6#   .- 5R      *  $DevExpress.Xpf.Docking.DocumentGroup  -   5        /  Name$/ 
documentGr��5R   )   $��Stretch=�6=   0   DestroyOnClosingChildren0 .  1   MDIStyle$1 Tabbed=�6|   2   ClosePageButtonShowMode$2 InAllTabPageHeaders=�6�   5S      5T      5U      5V      �� 5W   
   -   5        3 ��Name$3 label��5W      $��Label��6   $��24(�6/   $
��Auto��6=   $
��Left=�6J   $��75,3,0,0q�6e   $	��Top=�6w   $��32��6�   $��1��6�   $��1��6�   
����  �6�   � 5X   
   $
��Left=�6   $	��129��6*   $��
935,10,0,0q�67   $	��Top=�6K   $	��137��6c   .+�5Y      �� -    5        $3 _txtusername��5Y      $��Label��6*   $��Stretch=�6:   $��5,10,0,0q�6X   $	��Top=�6j   $��16(�6�   
���  ��6�   G� 5Z      -!   5        4 G�Name$4 passwordBox��5Z      $��Stretch=�6/   $��	0,46,0,65q�6M   $��Center=�6`   G� 5[      -"   5        $4 passwordBox1��5[      $��Stretch=�60   $��0,73,0,0q�6N   $	��Top=�6`   5 J� IsHitTestVisible5 . {�.  6�   �� 5\      -#   5        6 ��Name$6 _btnchangepass��5\      $��Change Pass��6-   $
��Left=�6C   $��	32,99,0,0q�6^   $	��Top=�6q   $��74��6�   6�   �� 5]      -$   5        $6 _btncancelsavepass��5]      $��X��61   $
��Left=�6=   $��	10,99,0,0q�6X   $	��Top=�6k   $��17��6�   $y�Hidden=�6�   {�.  6�   5^      5�      5�      