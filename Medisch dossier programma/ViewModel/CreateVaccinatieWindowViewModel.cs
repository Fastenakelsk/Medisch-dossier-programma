using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Medisch_dossier_programma.Extensions;
using Medisch_dossier_programma.Messages;
using Medisch_dossier_programma.Model;
using Medisch_dossier_programma.View;

namespace Medisch_dossier_programma.ViewModel
{
    class CreateVaccinatieWindowViewModel : BaseViewModel 
    {
        private string naam;
        private string isVerplicht;
        private DateTime gekregenDatum;
        private int studentID;

        public string Naam
        {
            get { return naam; }
            set
            {
                naam = value;
                NotifyPropertyChanged();
            }
        }
        public string IsVerplicht
        {
            get { return isVerplicht; }
            set
            {
                isVerplicht = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime GekregenDatum
        {
            get { return gekregenDatum; }
            set
            {
                gekregenDatum = value;
                NotifyPropertyChanged();
            }
        }
        public int StudentID
        {
            get { return studentID; }
            set
            {
                studentID = value;
                NotifyPropertyChanged();
            }
        }

        private Student selectedStudent;
        public Student SelectedStudent
        {
            get
            {
                return selectedStudent;
            }
            set
            {
                selectedStudent = value;
                NotifyPropertyChanged();
            }
        }
        
        private ObservableCollection<Vaccinatie> vaccinaties;
        public ObservableCollection<Vaccinatie> Vaccinaties
        {
            get { return vaccinaties; }
            set
            {
                vaccinaties = value;
                NotifyPropertyChanged();
            }
        }
        
        private ObservableCollection<Vaccinatie> vaccinatieLijst;
        public ObservableCollection<Vaccinatie> VaccinatieLijst
        {
            get { return vaccinatieLijst; }
            set
            {
                vaccinatieLijst = value;
                NotifyPropertyChanged();
            }
        }

        private void onStudentReceived(Student student)
        {
            selectedStudent = student;
            LeesVaccinaties();
        }

        public ICommand InsertCommand { get; set; }

        public CreateVaccinatieWindowViewModel()
        {
            InsertCommand = new BaseCommand(InsertVaccinatie);
            Messenger.Default.Register<Student>(this, onStudentReceived);
            LeesVaccinaties();
        }
        
        private void LeesVaccinaties()
        {
            if (selectedStudent != null)
            {
                VaccinatieDataService vDS = new VaccinatieDataService();
                Vaccinaties = new ObservableCollection<Vaccinatie>(vDS.GetVaccinatiesByStudentID(selectedStudent.Id));
            }
            
            VaccinatieLijstDataService vlDS = new VaccinatieLijstDataService();
            VaccinatieLijst = vlDS.GetVaccinatieLijst();
        }
        
        private void InsertVaccinatie()
        {
            DialogService dialogservice = new DialogService();

            var picker = gekregenDatum;
            VaccinatieDataService vDS = new VaccinatieDataService();
            Vaccinatie nieuweVaccinatie = new Vaccinatie();

            nieuweVaccinatie.Naam = naam;
            nieuweVaccinatie.IsVerplicht = isVerplicht;
            nieuweVaccinatie.GekregenDatum = picker.Date;
            nieuweVaccinatie.StudentID = selectedStudent.Id;
            
            Vaccinatie bestaandeVaccinatie = new Vaccinatie();

            bestaandeVaccinatie = vDS.getVaccinatieByNameAndStudentID(nieuweVaccinatie.Naam, nieuweVaccinatie.StudentID);
            
            if (bestaandeVaccinatie != null)
            {
                MessageBoxResult result = MessageBox.Show("Er is al een vaccinatie met deze naam bij deze student gevonden, bent u zeker dat u de vaccinatie wilt toevoegen ?",
                    "Dubbel gevonden",
                    MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes && nieuweVaccinatie.GekregenDatum > selectedStudent.Geboortedatum)
                {
                    vDS.InsertVaccinatie(nieuweVaccinatie);

                }
                else
                {
                    MessageBox.Show("Gekregen datum van de vaccinatie kan niet ouder zijn dan de geboortedatum van de student", "Onjuiste datum", MessageBoxButton.OK);
                }
            }
            else
            {
                if (nieuweVaccinatie.GekregenDatum < selectedStudent.Geboortedatum)
                {
                    MessageBox.Show("Gekregen datum van de vaccinatie kan niet ouder zijn dan de geboortedatum van de student",
                    "Onjuiste datum",
                    MessageBoxButton.OK);
                }
                else
                {
                    vDS.InsertVaccinatie(nieuweVaccinatie);
                }
            }
            LeesVaccinaties();
            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("VaccinatieToegevoegd"));
        }
    }
}
