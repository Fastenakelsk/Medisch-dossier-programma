   M S B A M L   `   `   `  ����T  PMedisch dossier programma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Medisch_dossier_programma.ViewMedisch_dossier_programma.View  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      1    +Medisch_dossier_programma.View.DetailWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Medisch_dossier_programma.View     5      6sys&clr-namespace:System;assembly=mscorlib     5      V RGu.Wpf.Adorners, Version=1.5.0.0, Culture=neutral, PublicKeyToken=6dfb64f9972bd31d$adornershttp://gu.se/Adorners  5      $	��420��5      $	��404��6     � Title$  Student Details��5         backgroundImage#��[  5       � Icon$ ../Images/icon1.ico��5       � DataContext 5	      ��   ViewModelLocator �� Source# [  �� Path$ DetailWindowViewModel�.��5      � $��1��6   $��20q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,    � ColumnDefinitions 5   
   �� 5       $	��160 �6   6-   �� 5!      $��* �6   6+   .+�5$   
   �� $��1��6     textBlockBackground#��[ 6!   $��Achternaam:��6N   ��5%      �� 5&       �� Color$ 
WhiteSmoke��6"    �� Opacity$	 0.7Q�65   5'      5)      �� 5*   
   $��2��6   #��[ 6!   $��	Voornaam:��6N   ��5+      �� 5,      $ 
WhiteSmoke��6"   $	 0.7Q�65   5-      5/      �� 50   
   $��3��6   #��[ 6!   $��Klas:��6N   ��51      �� 52      $ 
WhiteSmoke��6"   $	 0.7Q�65   53      55      �� 56   
   $��4��6   #��[ 6!   $��Geboortedatum:��6N   ��57      �� 58      $ 
WhiteSmoke��6"   $	 0.7Q�65   59      5;      �� 5<   
   $��5��6   #��[ 6!   $��	Geslacht:��6N   ��5=      �� 5>      $ 
WhiteSmoke��6"   $	 0.7Q�65   5?      5A      �� 5B   
   $��6��6   #��[ 6!   $��Telefoonnummer:��6N   ��5C      �� 5D      $ 
WhiteSmoke��6"   $	 0.7Q�65   5E      5G      �� 5H   
   $��7��6   #��[ 6!   $��E-mail Adres:��6N   ��5I      �� 5J      $ 
WhiteSmoke��6"   $	 0.7Q�65   5K      5M      �� 5O   
   $��1��6   $��1��6   $��0,0,0,10q�6�     Gu.Wpf.Adorners.Watermark	   Text	 6/   �� *SelectedStudent.Achternaam+��6o   �� *
Achternaam+6�   �� 5P   
   $��2��6   $��1��6   $��0,0,0,10q�6�   	 6/   �� *SelectedStudent.Voornaam+��6l   �� *
Voornaam+6�   �� 5Q   
   $��3��6   $��1��6   $��0,0,0,10q�6~   	 6/   �� *SelectedStudent.Klas+��6h   �� *Klas+6~   (  "System.Windows.Controls.DatePicker  5R   
   $��4��6   {�.  $��1��64   $��0,0,0,10q�6t   
   Text
 6E   �� *SelectedStudent.Geboortedatum+6t   �� 5S      $��5��6   $��1��6#   $��0,0,0,10q�6�   	 63   �� *SelectedStudent.Geslacht+��6p   �� *
Geslacht+6�   �� 5T   
   $��6��6   $��1��6   $��0,0,0,10q�6�   	 6/   �� * SelectedStudent.TelefoonNummer+��6r   �� *TelefoonNummer+6�   �� 5U   
   $��7��6   $��1��6   $��0,0,0,10q�6�   	 6/   �� *SelectedStudent.EmailAdres+��6n   �� *
EmailAdres+6�   �� 5W   
   $��8��6    
 Button#��[ 6   $��Bewaren��6>   $��
0,21,10,31q�6r   $��2��6�   ��6P   �� *UpdateCommand+6�   5Y      5Z      