using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Medisch_dossier_programma.Extensions;
using Medisch_dossier_programma.Messages;
using Medisch_dossier_programma.Model;

namespace Medisch_dossier_programma.ViewModel
{
    public class VaccinatieWindowViewModel : BaseViewModel
    {
        private DialogService dialogservice = new DialogService();

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

        private Vaccinatie selectedVaccinatie;
        public Vaccinatie SelectedVaccinatie
        {
            get
            {
                return selectedVaccinatie;
            }
            set
            {
                selectedVaccinatie = value;
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

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            if (message.State == "test123")
            {
                LeesVaccinaties();
            }
        }

        private void onStudentReceived(Student student)
        {
            selectedStudent = student;
            LeesVaccinaties();
            Messenger.Default.Unregister(this);
        }

        public VaccinatieWindowViewModel()
        {
            LeesVaccinaties();
            KoppelenCommands();
            // This function only executes the first Messenger method stated. Any additional Messenger methods are ignored.
            Messenger.Default.Register<Student>(this, onStudentReceived);
            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);
        }

        public ICommand WijzigenCommand { get; set; }
        public ICommand VerwijderenCommand { get; set; }
        public ICommand ToevoegenCommand { get; set; }

        private void KoppelenCommands()
        {
            WijzigenCommand = new BaseCommand(WijzigenVaccinatie);
            VerwijderenCommand = new BaseCommand(VerwijderVaccinatie);
            ToevoegenCommand = new BaseCommand(ToevoegenVaccinatie);
        }
        

        private void WijzigenVaccinatie()
        {
            Messenger.Default.Send<Vaccinatie>(selectedVaccinatie);
            dialogservice.VaccinatieDetailDialog();
        }

        private void LeesVaccinaties()
        {
            VaccinatieDataService vDS = new VaccinatieDataService();
            if (selectedStudent != null)
            {
                Vaccinaties = vDS.GetVaccinatiesByStudentID(selectedStudent.Id);
            }
        }

        private void ToevoegenVaccinatie()
        {
            dialogservice.ShowCreateVaccinatieDialog();
        }

        private void VerwijderVaccinatie()
        {
            MessageBoxResult result = MessageBox.Show("Bent u zeker dat u deze vaccinatie wilt verwijderen ?",
                "Vaccinatie verwijderen", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes && selectedVaccinatie != null)
            {
                VaccinatieDataService vDS = new VaccinatieDataService();
                vDS.VerwijderVaccinatie(SelectedVaccinatie);

                //LeesVaccinaties();

                Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("test123"));

            }
            
        }
    }
}
