   M S B A M L   `   `   `  ����T  PMedisch dossier programma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Medisch_dossier_programma.ViewMedisch_dossier_programma.View  5      ;    5Medisch_dossier_programma.View.VaccinatieDetailWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Medisch_dossier_programma.View     5      $	��266��5
      $	��404��6     � Title$  Vaccinatie Details��5         backgroundImage#��[  5       � Icon$ ../Images/icon1.ico��5       � DataContext 5      ��   ViewModelLocator �� Source# [  �� Path$% VaccinatieDetailWindowViewModel�.��5      � $��1��6   $��20q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   �� 5      $
��auto �6   6,   �� 5      $��42 �6   6*    � ColumnDefinitions 5   
   �� 5      $	��160 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��0��6     textBlockBackground#��[ 6!   $��Naam:��6N   ��5      �� 5       �� Color$ 
WhiteSmoke��6"    �� Opacity$	 0.7Q�65   5      5       �� 5!   
   $��1��6   #��[ 6!   $��
Verplicht:��6N   ��5"      �� 5#      $ 
WhiteSmoke��6"   $	 0.7Q�65   5$      5&      �� 5'   
   $��2��6   #��[ 6!   $��Toegediend:��6N   ��5(      �� 5)      $ 
WhiteSmoke��6"   $	 0.7Q�65   5*      5+   &   �� 5-   
   $��0��5/      $��1��50      	 �� DisplayMemberPath$
	 Naam��51      
 �� SelectedValuePath$

 Naam��52      ��5.      �� $ VaccinatieLijst� �� SelectedValue 53      �� *SelectedVaccinatie.Naam+ �� Mode$ TwoWay=��� 55   
   $��1��6   $��1��6   $��0,0,0,10q�6_   ��6/   �� * SelectedVaccinatie.IsVerplicht+6_   (  "System.Windows.Controls.DatePicker  56   
   $��2��6   $��1��6"   $��0,0,0,10q�6d      Text 62   �� *" SelectedVaccinatie.GekregenDatum+6d   �� 58   
   $��3��6   $��0��6   $��Bewaren��6.   $��0,20,0,0q�6b   ��6@   �� *UpdateCommand+6b   5:      5;      