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
    class VaccinatieLijstToevoegenWindowViewModel : BaseViewModel
    {
        private string naam;

        public string Naam
        {
            get { return naam; }
            set
            {
                naam = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand InsertCommand { get; set; }

        public VaccinatieLijstToevoegenWindowViewModel()
        {
          KoppelenCommands();  
        }

        private void KoppelenCommands()
        {
            InsertCommand = new BaseCommand(InsertVaccinatieLijst);
        }

        private void InsertVaccinatieLijst()
        {
            VaccinatieLijstDataService vlDS = new VaccinatieLijstDataService();
            Vaccinatie vaccinatie = new Vaccinatie();
            vaccinatie.Naam = naam;
            if (naam != "")
            {
                vlDS.InsertVaccinatieLijst(vaccinatie);
                Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("VaccinatieLijstToegevoegd"));
            }
        }

    }
}
