using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medisch_dossier_programma.Model
{
    public class Account : BaseModel
    {
        private int id;
        private string gebruikersNaam;
        private string paswoord;
        private int type;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

        public string GebruikersNaam
        {
            get { return gebruikersNaam; }
            set
            {
                gebruikersNaam = value;
                NotifyPropertyChanged();
            }
        }

        public string Paswoord
        {
            get { return paswoord; }
            set
            {
                paswoord = value;
                NotifyPropertyChanged();
            }
        }

        public int Type
        {
            get { return type; }
            set
            {
                type = value;
                NotifyPropertyChanged();
            }
        }
    }
}
