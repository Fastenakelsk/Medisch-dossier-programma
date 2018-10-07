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
    public class DetailWindowViewModel : BaseViewModel
    {
        private int id;
        private string achternaam;
        private string voornaam;
        private DateTime geboortedatum;
        private string geslacht;
        private string klas;
        private string telefoonNummer;
        private string emailAdres;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set
            {
                achternaam = value;
                NotifyPropertyChanged();
            }
        }

        public string Voornaam
        {
            get { return voornaam; }
            set
            {
                voornaam = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime Geboortedatum
        {
            get { return geboortedatum; }
            set
            {
                geboortedatum = value;
                NotifyPropertyChanged();
            }
        }

        public string Geslacht
        {
            get { return geslacht; }
            set
            {
                geslacht = value;
                NotifyPropertyChanged();
            }
        }

        public string Klas
        {
            get { return klas; }
            set
            {
                klas = value;
                NotifyPropertyChanged();
            }
        }

        public string TelefoonNummer
        {
            get { return telefoonNummer; }
            set
            {
                telefoonNummer = value;
                NotifyPropertyChanged();
            }
        }

        public string EmailAdres
        {
            get { return emailAdres; }
            set
            {
                emailAdres = value;
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

        public ICommand UpdateCommand { get; set; }

        public DetailWindowViewModel()
        {
            Messenger.Default.Register<Student>(this, onStudentReceived);
            
            UpdateCommand = new BaseCommand(UpdateStudent);
        }

        private void onStudentReceived(Student student)
        {
            selectedStudent = student;
        }

        private void UpdateStudent()
        {
            StudentDataService ds = new StudentDataService();
            Student studentMetUpdates = SelectedStudent;
            if (!String.IsNullOrWhiteSpace(Achternaam))
            {
                studentMetUpdates.Achternaam = Achternaam;
            }
            if (!String.IsNullOrWhiteSpace(Voornaam))
            {
                studentMetUpdates.Voornaam = Voornaam;
            }
            if (!String.IsNullOrWhiteSpace(Geslacht))
            {
                studentMetUpdates.Geslacht = Geslacht;
            }
            if (!String.IsNullOrWhiteSpace(Klas))
            {
                studentMetUpdates.Klas = Klas;
            }
            if (!String.IsNullOrWhiteSpace(TelefoonNummer))
            {
                studentMetUpdates.TelefoonNummer = TelefoonNummer;
            }
            if (!String.IsNullOrWhiteSpace(EmailAdres))
            {
                studentMetUpdates.EmailAdres = EmailAdres;
            }
            ds.UpdateStudent(studentMetUpdates);
            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Completed"));
            Achternaam = string.Empty;
            Voornaam = string.Empty;
            Geslacht = string.Empty;
            Klas = string.Empty;
            TelefoonNummer = string.Empty;
            EmailAdres = string.Empty;
        }
    }
}
