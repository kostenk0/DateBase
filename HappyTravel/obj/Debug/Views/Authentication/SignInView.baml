   M S B A M L   `   `   `  ����F  BHappyTravel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:HappyTravel.Views.Authentication HappyTravel.Views.Authentication  5   	   1    +HappyTravel.Views.Authentication.SignInView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:HappyTravel.Views.Authentication     5   	   $	��150��5   	   $	��300��6   .��5	      �   � RowDefinitions  5
   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��30��6   .��6)   Login:61   �� 5   
   $��0��6   $��2��6   $��20��63   $��40, 5, 5, 5q�6?   ��6T   �� *Login+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��6   $��30��6   .��6)   	Password:64   �� 5   
   $��1��6   $��2��6   $��20��63   $��60, 5, 5, 5q�6?   ��6T   �� *
Password+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $��2��6   $��0��6   $��Stretch=�6.   $��Center=�6L   $��5q�6g   $��Sign in��6r   ��6�   �� *SignInCommand+�� 5   
   $��2��6   $��1��6   $��Stretch=�6.   $��Center=�6L   $��5q�6g   $��Sign up��6r   ��6�   �� *SignUpCommand+�� 5   
   $��3��6   $��0��6   $��2��6.   $��Stretch=�6B   $��Center=�6`   $��5q�6{   $��Close��6�   ��6�   �� *CloseCommand+5      5      