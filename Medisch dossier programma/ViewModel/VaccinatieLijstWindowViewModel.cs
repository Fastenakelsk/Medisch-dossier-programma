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

namespace Medisch_dossier_programma.ViewModel
{
    class VaccinatieLijstWindowViewModel : BaseViewModel
    {
        private DialogService dialogservice = new DialogService();

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

        private void getVaccinatieLijst()
        {
            VaccinatieLijstDataService vlDS = new VaccinatieLijstDataService();
            VaccinatieLijst = vlDS.GetVaccinatieLijst();
        }

        public VaccinatieLijstWindowViewModel()
        {
            getVaccinatieLijst();  
            KoppelenCommands();
            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);
        }

        public ICommand ToevoegenCommand { get; set; }
        public ICommand VerwijderenCommand { get; set; }

        private void KoppelenCommands()
        {
            ToevoegenCommand = new BaseCommand(VaccinatieLijstToevoegen);
            VerwijderenCommand = new BaseCommand(VerwijderVaccinatieLijst);
        }

        private void VaccinatieLijstToevoegen()
        {
            dialogservice.ShowVaccinatieLijstToevoegenDialog();
        }

        private void VerwijderVaccinatieLijst()
        {
            MessageBoxResult result = MessageBox.Show("Bent u zeker dat u deze vaccinatie wilt verwijderen ?",
    "Vaccinatie verwijderen", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes && selectedVaccinatie != null)
            {
                VaccinatieLijstDataService vlDS = new VaccinatieLijstDataService();
                vlDS.VerwijderVaccinatie(SelectedVaccinatie);

                getVaccinatieLijst();

            }
        }

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            if (message.State == "VaccinatieLijstToegevoegd")
            {
                getVaccinatieLijst();
            }
        }
    }
}
