   M S B A M L   `   `   `  ����T  PMedisch dossier programma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Medisch_dossier_programma.ViewMedisch_dossier_programma.View  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      4    .Medisch_dossier_programma.View.ToevoegenWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Medisch_dossier_programma.View     5      6sys&clr-namespace:System;assembly=mscorlib     5      $	��434��5      $	��400��6     � Title$  Student Toevoegen��5         backgroundImage#��[  5       � Icon$ ../Images/icon1.ico��5       � DataContext 5      ��   ViewModelLocator �� Source# [  �� Path$ ToevoegenWindowViewModel�.��5      � $��1��6   $��20q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $	��160 �6   6-   �� 5      $��* �6   6+   .+�5!   
   �� $��1��6     textBlockBackground#��[ 6!   $��Achternaam:��6N   ��5"      �� 5#       �� Color$ 
WhiteSmoke��6"    �� Opacity$	 0.7Q�65   5$      5&      �� 5'   
   $��2��6   #��[ 6!   $��	Voornaam:��6N   ��5(      �� 5)      $ 
WhiteSmoke��6"   $	 0.7Q�65   5*      5,      �� 5-   
   $��3��6   #��[ 6!   $��Klas:��6N   ��5.      �� 5/      $ 
WhiteSmoke��6"   $	 0.7Q�65   50      52      �� 53   
   $��4��6   #��[ 6!   $��Geboortedatum:��6N   ��54      �� 55      $ 
WhiteSmoke��6"   $	 0.7Q�65   56      58      �� 59   
   $��5��6   #��[ 6!   $��	Geslacht:��6N   ��5:      �� 5;      $ 
WhiteSmoke��6"   $	 0.7Q�65   5<      5>      �� 5?   
   $��6��6   #��[ 6!   $��Telefoonnummer:��6N   ��5@      �� 5A      $ 
WhiteSmoke��6"   $	 0.7Q�65   5B      5D      �� 5E   
   $��7��6   #��[ 6!   $��E-mail Adres:��6N   ��5F      �� 5G      $ 
WhiteSmoke��6"   $	 0.7Q�65   5H      5J      �� 5L   
   $��1��6   $��1��6   $��0,0,0,10q�6X   ��6/   �� *
Achternaam+	 �� Mode$	 TwoWay=�6X   �� 5M   
   $��2��6   $��1��6   $��0,0,0,10q�6V   ��6/   �� *
Voornaam+$	 TwoWay=�6V   �� 5N   
   $��3��6   $��1��6   $��0,0,0,10q�6R   ��6/   �� *Klas+$	 TwoWay=�6R   (  "System.Windows.Controls.DatePicker  5P   
   $��4��6   $��1��6"   $��0,0,0,10q�6^   
   Text
 62   �� *Geboortedatum+$	 TwoWay=�6^   �� 5Q   
   $��5��6   $��1��6   $��0,0,0,10q�6V   ��6/   �� *
Geslacht+$	 TwoWay=�6V   �� 5R   
   $��6��6   $��1��6   $��0,0,0,10q�6\   ��6/   �� *TelefoonNummer+$	 TwoWay=�6\   �� 5S   
   $��7��6   $��1��6   $��0,0,0,10q�6X   ��6/   �� *
EmailAdres+$	 TwoWay=�6X   �� 5U   
   $��8��6    
 Button#��[ 6   $��Bewaren��6>   $��0,20,0,0q�6r   ��6P   �� *InsertCommand+6r   5W      5X      