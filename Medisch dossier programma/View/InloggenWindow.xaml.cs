using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Medisch_dossier_programma.Model;
using Medisch_dossier_programma.Messages;
using Medisch_dossier_programma.Extensions;

namespace Medisch_dossier_programma.View
{
    /// <summary>
    /// Interaction logic for InloggenWindow.xaml
    /// </summary>
    public partial class InloggenWindow : Window
    {
        public InloggenWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ingevuldeGebruikersNaam = loginGebruikersNaam.Text;
            string ingevuldePaswoord = loginWachtwoord.Password;
            AccountDataService ds = new AccountDataService();
            DialogService dialogservice = new DialogService();
            ds.SetAllToFalse();
            Account checkAccount = ds.GetAccount(ingevuldeGebruikersNaam);

            if (checkAccount != null && checkAccount.GebruikersNaam == ingevuldeGebruikersNaam && checkAccount.Paswoord == ingevuldePaswoord)
            {
                ds.SetIngelogdAccount(checkAccount);
                dialogservice.showMainWindow();
            }
            else
            {
                MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord", "Fout", MessageBoxButton.OK);
                loginGebruikersNaam.Text = "";
                loginWachtwoord.Password = "";
            }
        }

        private void PaswoordButton_Click(object sender, RoutedEventArgs e)
        {
            DialogService dialogservice = new DialogService();
            dialogservice.ShowChangePasswordWindow();
        }
    }
}
