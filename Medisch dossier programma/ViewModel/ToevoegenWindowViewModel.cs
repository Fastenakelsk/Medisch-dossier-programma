using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Medisch_dossier_programma.Model;
using Medisch_dossier_programma.Messages;
using Medisch_dossier_programma.Extensions;
using System.Windows.Input;

namespace Medisch_dossier_programma.ViewModel
{
    public class ToevoegenWindowViewModel : BaseViewModel
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

       public ICommand InsertCommand { get; set; }

       public ToevoegenWindowViewModel()
        {
            InsertCommand = new BaseCommand(InsertStudent);
        }

        private void InsertStudent()
        {
            DialogService dialogservice = new DialogService();
            var picker = geboortedatum;
            StudentDataService ds = new StudentDataService();
            Student nieuweStudent = new Student();
            nieuweStudent.Achternaam = achternaam;
            nieuweStudent.Voornaam = voornaam;
            nieuweStudent.Klas = klas;
            nieuweStudent.Geboortedatum = picker.Date;
            nieuweStudent.Geslacht = geslacht;
            nieuweStudent.TelefoonNummer = telefoonNummer;
            nieuweStudent.EmailAdres = emailAdres;

            Student bestaandeStudent = new Student();

            bestaandeStudent = ds.GetStudent(nieuweStudent.Voornaam, nieuweStudent.Achternaam);

            if (bestaandeStudent != null)
            {
                if (nieuweStudent.Voornaam == bestaandeStudent.Voornaam && nieuweStudent.Achternaam == bestaandeStudent.Achternaam && picker.Date.Year > 1900 && picker.Date < DateTime.Now)
                {
                    MessageBoxResult resultaat = MessageBox.Show(
                        "Een student met deze naam is al gevonden in het systeem, bent u zeker dat u deze student wilt aanmaken ?",
                        "Dubbel gevonden", MessageBoxButton.YesNo);

                    if (resultaat == MessageBoxResult.Yes)
                    {
                        ds.InsertStudent(nieuweStudent);


                    }
                }
                else
                {
                    if (picker.Date.Year > 1900 && picker.Date < DateTime.Now)
                    {
                        ds.InsertStudent(nieuweStudent);

                    }
                    else
                    {
                        MessageBox.Show(
                            "U probeert een student aan te maken met een ongeldige geboortedatum, probeer nog eens",
                            "Ongeldige geboortedatum", MessageBoxButton.OK);
                    }
                }
            }
            else
            {
                if (picker.Date.Year > 1900 && picker.Date < DateTime.Now)
                {
                    ds.InsertStudent(nieuweStudent);


                }
                else
                {
                    MessageBox.Show(
                        "U probeert een student aan te maken met een ongeldige geboortedatum, probeer nog eens",
                        "Ongeldige geboortedatum", MessageBoxButton.OK);
                }
            }
            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Completed"));
        }
    }
}
