using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Medisch_dossier_programma.Model
{
    public class Student : BaseModel
    {
        private int id;
        private string achternaam;
        private string voornaam;
        private DateTime geboortedatum;
        private string geslacht;
        private string klas;
        private string telefoonNummer;
        private string emailAdres;
        public ObservableCollection<Vaccinatie> vaccinaties;

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
            get { return geboortedatum;}
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
            get { return telefoonNummer;}
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

        public ObservableCollection<Vaccinatie> Vaccinaties
        {
            get { return vaccinaties; }
            set
            {
                vaccinaties = value;
                NotifyPropertyChanged();
            }
        }


        public override string ToString()
        {
            return achternaam + " " + voornaam + " " + klas;
        }
    }
}
