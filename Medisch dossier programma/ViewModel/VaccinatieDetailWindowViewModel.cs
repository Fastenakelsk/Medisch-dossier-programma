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
    class VaccinatieDetailWindowViewModel : BaseModel
    {
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

        public ICommand UpdateCommand { get; set; }

        public VaccinatieDetailWindowViewModel()
        {
            Messenger.Default.Register<Vaccinatie>(this, onVaccinatieReceived);

            UpdateCommand = new BaseCommand(UpdateVaccinatie);
            VaccinatieLijstDataService vlDS = new VaccinatieLijstDataService();
            VaccinatieLijst = vlDS.GetVaccinatieLijst();
        }

        private void onVaccinatieReceived(Vaccinatie vaccinatie)
        {
            selectedVaccinatie = vaccinatie;

        }

        private void UpdateVaccinatie()
        {
            VaccinatieDataService vDS = new VaccinatieDataService();
            vDS.UpdateVaccinatie(SelectedVaccinatie);

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Completed"));
        }
    }
}
