   M S B A M L   `   `   `  ����F  BHappyTravel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HappyTravel.ViewsHappyTravel.Views  5   	   %    HappyTravel.Views.AddClientView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HappyTravel.Views     5   	   $	��450��5   	   $	��300��6   .��5	      �   � RowDefinitions  5
   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��30��6   .��6)   Pasport number:6:   �� 5   
   $��0��6   $��2��6   $��20��63   $��100, 5, 5, 5q�6?   ��6U   �� *PasportNumber+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��6   $��30��6   .��6)   
Surname:63   �� 5   
   $��1��6   $��2��6   $��20��63   $��60, 5, 5, 5q�6?   ��6T   �� *Name+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $��2��6   $��30��6   .��6)   Name:60   �� 5   
   $��2��6   $��2��6   $��20��63   $��45, 5, 5, 5q�6?   ��6T   �� *	Surname+$ TwoWay=�$ PropertyChanged=�6�   �� 5    
   $��3��6   $��30��6   .��6)   Father's name:69   �� 5!   
   $��3��6   $��2��6   $��20��63   $��85, 5, 5, 5q�6?   ��6T   �� *FathersName+$ TwoWay=�$ PropertyChanged=�6�   �� 5"   
   $��4��6   $��30��6   .��6)   Date of birth:69   (  "System.Windows.Controls.DatePicker  5#   
   $��4��6   $��2��6"   $��25��66   $��80, 5, 5, 5q�6B      Text 6W   �� *	BirthDate+$ TwoWay=�$ PropertyChanged=�6�   �� 5$   
   $��5��6   $��30��6   .��6)   	E-mail:62   �� 5%   
   $��5��6   $��2��6   $��20��63   $��45, 5, 5, 5q�6?   ��6T   �� *Email+$ TwoWay=�$ PropertyChanged=�6�   �� 5&   
   $��6��6   $��30��6   .��6)   Phone number:68   �� 5'   
   $��6��6   $��2��6   $��20��63   $��90, 5, 5, 5q�6?   ��6T   �� *PhoneNumber+$ TwoWay=�$ PropertyChanged=�6�   �� 5(   
   $��7��6   $��0��6   $��Stretch=�6.   $��Center=�6L   $��5q�6g   $��Ok��6r   ��6   �� *	OkCommand+�� 5)   
   $��7��6   $��1��6   $��Stretch=�6.   $��Center=�6L   $��5q�6g   $��Cansel��6r   ��6�   �� *CanselCommand+5*      5+      