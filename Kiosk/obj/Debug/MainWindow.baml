   M S B A M L   `   `   `  ����@  <Kiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KioskKiosk  5   	       Kiosk.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Kiosk     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��9* �6   .+�5   
   � $��0��6   $��Center=�5      .+�5      �� -   5         ��Name$
 Time��5      $��2020-09-22 12:01��5      $��20 0 0 0q�5      $
��Left=�5      $	��Top=�5      $��20(�5      
���   �5      �� 5      -   5         ��Name$ 
HomeButton��5      $��
홈 이동��5      $��80��5      $��30��5       $��0 0 20 0q�5!      
�������$	��Top=�5#      $��Right=�5$      6-   5%      � 5'   
   $��1��6   .+�5(       � -   5          �Name$ FrameLayout��5)        � NavigationUIVisibility$ Hidden=�5*        � Source$ intro/IntroPage.xaml?�5+      5,      5-      5.      