   M S B A M L   `   `   `  ����T  PMedisch dossier programma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Medisch_dossier_programma.ViewMedisch_dossier_programma.View  5      <    6Medisch_dossier_programma.View.CreateVaccinationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Medisch_dossier_programma.View     5      $	��280��5
      $	��400��6     � Title$  Vaccinatie Maken��5         backgroundImage#��[  5       � Icon$ ../Images/icon1.ico��5       � DataContext 5      ��   ViewModelLocator �� Source# [  �� Path$% CreateVaccinatieWindowViewModel�.��5      � $��1��6   $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6-   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $	��150 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��1��6     textBlockBackground#��[ 6!   $��Naam:��6N   ��5      �� 5       �� Color$ 
WhiteSmoke��6"    �� Opacity$	 0.7Q�65   5      5!      �� 5"   
   $��2��6   #��[ 6!   $��
Verplicht:��6N   ��5#      �� 5$      $ 
WhiteSmoke��6"   $	 0.7Q�65   5%      5'      �� 5(   
   $��3��6   #��[ 6!   $��Toegediend:��6N   ��5)      �� 5*      $ 
WhiteSmoke��6"   $	 0.7Q�65   5+      5-      �� 5/   
   -   5        	 ��Name$	 ComboBox��56      $��1��51      $��1��52      
 �� DisplayMemberPath$

 Naam��53       �� SelectedValuePath$
 Naam��54      ��50      �� $ VaccinatieLijst� �� SelectedValue 55      �� *Naam+ �� Mode$ TwoWay=�56      �� 57   
   $��2��6   $��1��6   $��0,0,0,10q�6Y   ��6/   �� *IsVerplicht+$ TwoWay=�6Y   (  "System.Windows.Controls.DatePicker  58   
   $��3��6   $��1��6"   $��0,0,0,10q�6^      Text 62   �� *GekregenDatum+$ TwoWay=�6^   �� 5:   
   $��4��6    
 Button#��[ 6   $��Bewaren��6>   ��6P   �� *InsertCommand+5<      5=      