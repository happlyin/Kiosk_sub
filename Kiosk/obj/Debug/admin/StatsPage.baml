   M S B A M L   `   `   `  ����@  <Kiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Kiosk.adminKiosk.admin  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          Kiosk.admin.StatsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Kiosk.admin     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        N� Title$  	StatsPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��9* �6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ Vertical=�5      $	��Top=�5      $��Center=�5      .+�5      �� $ 
Horizontal=�5      
�������.+�5      �� -   5        $��10q�5      $��15(�5      
�������
������ .��5"   0   총액64   �� 5#      -   5        $��10q�5$      $��15(�5%      
�������
������ .��5(   0   메뉴64   �� 5)      -   5        $��10q�5*      $��15(�5+      
�������
������ .��5.   0   카테고리66   �� 5/      -   5        $��10q�50      $��15(�51      
�������
������ .��54   0   	테이블65   �� 55      -   5        $��10q�56      $��15(�57      
�������
������ .��5:   0   일별64   �� 5;      -   5        $��10q�5<      $��15(�5=      
�������
������ .��5@   0   유저64   5A      5C      5D      � 5F   
   $��1��6   .+�5G       � -   5          �Name$ FrameLayout1��5H        � NavigationUIVisibility$ Hidden=�5I        � Source$% ../data/AllProfitsDataPage.xaml?�5J      5K      5]      5^      