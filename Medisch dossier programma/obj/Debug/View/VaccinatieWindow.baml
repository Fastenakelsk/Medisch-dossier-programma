   M S B A M L   `   `   `  ����T  PMedisch dossier programma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Medisch_dossier_programma.ViewMedisch_dossier_programma.View  5      5    /Medisch_dossier_programma.View.VaccinatieWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Medisch_dossier_programma.View     5      $	��720��5	      $	��800��6      backgroundImage#��[  5
        � Title$  Vaccinaties��5       � Icon$ ../Images/icon1.ico��5       � DataContext 5      ��   ViewModelLocator �� Source# [  �� Path$ VaccinatieWindowViewModel�.��5      �  � ColumnDefinitions 5   
   �� 5      $	��350 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��20q�6   $	��280��5   ?   ��5      �� *Vaccinaties+ �� SelectedItem 5      �� *SelectedVaccinatie+��5      �� 5      .R�5      �� $��14(�65   ��6   �� *Naam+65   5      5      � 5   
   $��1��6   $��49q�6    � RowDefinitions 5      �� 5      $
��auto �6    61   �� 5      $
��auto �6    60   �� 5       $
��auto �6    60   �� 5!      $
��auto �6    60   �� 5"      $
��auto �6    60   �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      $
��auto �6    60    5(      �� 5)      $��* �6#   6/   �� 5*      $��* �6#   6/   .+�5,      �� $��0��6     textBlockBackground#��[ 6%   $��Naam:��6R   ��5-      �� 5.       �� Color$ 
WhiteSmoke��6&   	 �� Opacity$		 0.7Q�69   5/      51      �� 52      $��1��6   #��[ 6%   $��
Verplicht:��6R   ��53      �� 54      $ 
WhiteSmoke��6&   $		 0.7Q�69   55      57      �� 58      $��2��6   #��[ 6%   $��Toegediend:��6R   ��59      �� 5:      $ 
WhiteSmoke��6&   $		 0.7Q�69   5;      5=      �� 5?      $��0��6   #��[ 6%   $��1��6R   ��6b   �� *SelectedVaccinatie.Naam+��5@      �� 5A      $ 
WhiteSmoke��6&   $		 0.7Q�69   5B      5D      �� 5E      $��1��6   #��[ 6%   $��1��6R   ��6b   �� * SelectedVaccinatie.IsVerplicht+��5F      �� 5G      $ 
WhiteSmoke��6&   $		 0.7Q�69   5H      5J      �� 5K      $��2��6   #��[ 6%   $��1��6R   ��6b   �� *" SelectedVaccinatie.GekregenDatum+
 �� StringFormat$
 {0:dd-MM-yyyy}����5L      �� 5M      $ 
WhiteSmoke��6&   $		 0.7Q�69   5N      5P      �� 5Q      $��3��6    
 Button#��[ 6"   $��	Verwijder��6B   $��	0,0,10,10q�6V   ��6j   �� *VerwijderenCommand+�� 5R      $��4��6   #��[ 6"   $��	Toevoegen��6B   $��	0,0,10,10q�6V   ��6j   �� *ToevoegenCommand+�� 5S      $��5��6   #��[ 6"   $��Wijzig��6B   $��	0,0,10,10q�6S   ��6g   �� *WijzigenCommand+5T      5U      5V      