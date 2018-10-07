using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Medisch_dossier_programma.Model;
using Medisch_dossier_programma.Messages;
using Medisch_dossier_programma.Extensions;
using System.Windows.Input;
using Medisch_dossier_programma.View;

namespace Medisch_dossier_programma.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private DialogService dialogservice = new DialogService();
        private ObservableCollection<Student> studenten;
        public ObservableCollection<Student> Studenten
        {
            get { return studenten; }
            set
            {
                studenten = value;
                NotifyPropertyChanged();
            }
        }

        private Student selectedStudent;
        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                NotifyPropertyChanged();
            }
        }

        private bool showMenu = false;

        public bool ShowMenu
        {
            get { return showMenu; }
        }

        public MainWindowViewModel()
        {
            LeesGegevens();
            KoppelenCommands();
            ShowOrHideMenu();
            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);
        }

        private void ShowOrHideMenu()
        {
            Account account = new Account();
            AccountDataService aDS = new AccountDataService();
            account = aDS.GetIngelogdAccount();
            if (account.Type == 1)
            {
                showMenu = true;
            }
        }

        private void LeesGegevens()
        {
            StudentDataService ds = new StudentDataService();
            Studenten = new ObservableCollection<Student>(ds.GetStudenten());
        }

        public ICommand WijzigenCommand { get; set; }
        public ICommand VerwijderenCommand { get; set; }
        public ICommand ToevoegenCommand { get; set; }
        public ICommand VaccinatieCommand { get; set; }
        public ICommand AccountsCommand { get; set; }
        public ICommand VaccinatieLijstCommand { get; set; }

        private void WijzigAccounts()
        {
            dialogservice.ShowAccountsWindow();
        }

        private void WijzigVaccinatieLijst()
        {
            dialogservice.ShowVaccinatieLijstWindow();
        }

        private void KoppelenCommands()
        {
            WijzigenCommand = new BaseCommand(WijzigenStudent);
            VerwijderenCommand = new BaseCommand(VerwijderStudent);
            ToevoegenCommand = new BaseCommand(ToevoegenStudent);
            VaccinatieCommand = new BaseCommand(StudentVaccinaties);
            VaccinatieLijstCommand = new BaseCommand(WijzigVaccinatieLijst);
            AccountsCommand = new BaseCommand(WijzigAccounts);
        }

        private void WijzigenStudent()
        {
            if (SelectedStudent != null)
            {
                Messenger.Default.Send<Student>(selectedStudent);
                dialogservice.ShowDetailDialog();
            }
        }

        private void StudentVaccinaties()
        {
            if (SelectedStudent != null)
            {
                Messenger.Default.Send<Student>(SelectedStudent);
                dialogservice.ShowVaccinatieDialog();
            }
        }

        private void VerwijderStudent()
        {
            MessageBoxResult result = MessageBox.Show("Bent u zeker dat u deze student wilt verwijderen ?",
                "Student verwijderen", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes && selectedStudent != null)
            {
                    StudentDataService ds = new StudentDataService();
                    ds.VerwijderStudent(SelectedStudent);

                    LeesGegevens();

                    Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Completed"));
            }

        }

        private void ToevoegenStudent()
        {
            dialogservice.ShowToevoegenDialog();
        }

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            if (message.State == "Completed")
            {
                LeesGegevens();
            }
        }
    }
}
