   M S B A M L   `   `   `  ����T  PMedisch dossier programma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Medisch_dossier_programma.ViewMedisch_dossier_programma.View  5   	   *    $Medisch_dossier_programma.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Medisch_dossier_programma.View     5   	     � Title$  Medisch Dossier Programma��5	   	   $	��720��6+   $	��800��68      backgroundImage#��[  5
   	    � Icon$ ../Images/icon1.ico��5   	    � DataContext 5   	   ��   ViewModelLocator �� Source# [  �� Path$ MainWindowViewModel� � 	Resources 5        	Converter��%   &	       �� 5   
   6'   5      .��5      ]� .+�5      o� $	��Top=�6   $��28��6    y�6,   �� $ ShowMenu� �� 	Converter# [ .@�5      m� $��Accounts��6   $��0,5,5,0q�6)    m� Command 6:   �� *AccountsCommand+m� 5      $��VaccinatieLijst��6   $��0,5,5,0q�60    6A   �� *VaccinatieLijstCommand+5      � 5       � ColumnDefinitions 5      �� 5      $	��350 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��20q�6   $	��280��5   <   ��5      �� *	Studenten+	 �� SelectedItem	 5      �� *SelectedStudent+��5      �� 5       .R�5!      �� $��14(�61   ��6   �� 61   5"      5$      � 5&   
   $��1��6   $��49q�6   
 � RowDefinitions
 5'      �� 5(      $
��auto �6    61   �� 5)      $
��auto �6    60   �� 5*      $
��auto �6    60   �� 5+      $
��auto �6    60   �� 5,      $
��auto �6    60   �� 5-      $
��auto �6    60   �� 5.      $
��auto �6    60   �� 5/      $
��auto �6    60   �� 50      $
��auto �6    60   �� 51      $
��auto �6    60   �� 52      $
��auto �6    60    55      �� 56      $��* �6#   6/   �� 57      $	��200 �6#   61   .+�59      �� $��0��6     textBlockBackground#��[ 6%   $��Achternaam:��6R   $
��Bold"�6e   ��5:      �� 5;       �� Color$ 
WhiteSmoke��6&    �� Opacity$	 0.7Q�69   5<      5>      �� 5?      $��1��6   #��[ 6%   $��	Voornaam:��6R   $
��Bold"�6c   ��5@      �� 5A      $ 
WhiteSmoke��6&   $	 0.7Q�69   5B      5D      �� 5E      $��2��6   #��[ 6%   $��Klas:��6R   $
��Bold"�6_   ��5F      �� 5G      $ 
WhiteSmoke��6&   $	 0.7Q�69   5H      5J      �� 5K      $��3��6   #��[ 6%   $��Geboortedatum:��6R   $
��Bold"�6h   ��5L      �� 5M      $ 
WhiteSmoke��6&   $	 0.7Q�69   5N      5P      �� 5Q      $��4��6   #��[ 6%   $��	Geslacht:��6R   $
��Bold"�6c   ��5R      �� 5S      $ 
WhiteSmoke��6&   $	 0.7Q�69   5T      5V      �� 5W      $��5��6   #��[ 6%   $��Telefoonnummer:��6R   $
��Bold"�6i   ��5X      �� 5Y      $ 
WhiteSmoke��6&   $	 0.7Q�69   5Z      5\      �� 5]      $��6��6   #��[ 6%   $��EmailAdres:��6R   $
��Bold"�6e   ��5^      �� 5_      $ 
WhiteSmoke��6&   $	 0.7Q�69   5`      5b      �� 5d      $��0��6   #��[ 6%   $��1��6R   ��6b   �� *SelectedStudent.Achternaam+��5e      �� 5f      $ 
WhiteSmoke��6&   $	 0.7Q�69   5g      5i      �� 5j      $��1��6   #��[ 6%   $��1��6R   ��6b   �� *SelectedStudent.Voornaam+��5k      �� 5l      $ 
WhiteSmoke��6&   $	 0.7Q�69   5m      5o      �� 5p      $��2��6   #��[ 6%   $��1��6R   ��6b   �� *SelectedStudent.Klas+��5q      �� 5r      $ 
WhiteSmoke��6&   $	 0.7Q�69   5s      5u      �� 5v      $��3��6   #��[ 6%   $��1��6R   ��6b   �� *SelectedStudent.Geboortedatum+ �� StringFormat$ {0:dd-MM-yyyy}����5w      �� 5x      $ 
WhiteSmoke��6&   $	 0.7Q�69   5y      5{      �� 5|      $��4��6   #��[ 6%   $��1��6R   ��6b   �� *SelectedStudent.Geslacht+��5}      �� 5~      $ 
WhiteSmoke��6&   $	 0.7Q�69   5      5�      �� 5�      $��5��6   #��[ 6%   $��1��6R   ��6b   �� * SelectedStudent.TelefoonNummer+��5�      �� 5�      $ 
WhiteSmoke��6&   $	 0.7Q�69   5�      5�      �� 5�      $��6��6   #��[ 6%   $��1��6R   ��6b   �� *SelectedStudent.EmailAdres+��5�      �� 5�      $ 
WhiteSmoke��6&   $	 0.7Q�69   5�      5�      �� 5�      $��7��6    
 Button#��[ 6"   $��Wijzig��6B   $��	0,0,10,10q�6S   ��6g   �� *WijzigenCommand+�� 5�      $��8��6   #��[ 6"   $��	Verwijder��6B   $��	0,0,10,10q�6V   ��6j   �� *VerwijderenCommand+�� 5�      $��10��6   #��[ 6#   $��Vaccinaties��6C   $��0,41,10,-31q�6Y   ��6o   �� *VaccinatieCommand+�� 5�      $��10��6   #��[ 6#   $��	Toevoegen��6C   $��	0,0,10,10q�6W   ��6k   �� *ToevoegenCommand+5�      5�      5�      5�      