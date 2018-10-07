using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medisch_dossier_programma.Model
{
    public class Vaccinatie : BaseModel
    {
        private int id;
        private string naam;
        private string isVerplicht;
        private DateTime gekregenDatum;
        private int studentID;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

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
    }
}
