using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medisch_dossier_programma.Model
{
    class VaccinatieLijst : BaseModel
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
    }
}
