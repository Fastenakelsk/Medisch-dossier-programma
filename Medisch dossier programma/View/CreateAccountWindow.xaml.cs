using System;
using System.Collections.Generic;
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
using Medisch_dossier_programma.Extensions;
using Medisch_dossier_programma.Messages;
using Medisch_dossier_programma.Model;

namespace Medisch_dossier_programma.View
{
    /// <summary>
    /// Interaction logic for CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ingevuldeGebruikersNaam = registreerGebruikersNaam.Text;
            string ingevuldePaswoord = registreerWachtwoord.Password;
            AccountDataService ds = new AccountDataService();
            DialogService dialogservice = new DialogService();

            Account checkAccount = ds.GetAccount(ingevuldeGebruikersNaam);

            if (checkAccount == null)
            {
                checkAccount = new Account();
                checkAccount.GebruikersNaam = "#########################################";
            }

            if (checkAccount.GebruikersNaam.Equals(ingevuldeGebruikersNaam))
            {
                MessageBox.Show("Account met deze naam bestaat al", "Naam in gebruik", MessageBoxButton.OK);
            }
            else
            {
                if (ingevuldePaswoord.Length < 4)
                {
                    MessageBox.Show("Paswoord moet minimum 4 tekens lang zijn", "Paswoord te kort", MessageBoxButton.OK);
                }
                else
                {
                    Account newAccount = new Account();
                    newAccount.GebruikersNaam = ingevuldeGebruikersNaam;
                    newAccount.Paswoord = ingevuldePaswoord;
                    newAccount.Type = 0;
                    ds.InsertAccount(newAccount);
                    MessageBox.Show("Account succesvol aangemaakt, u kan nu inloggen", "Succes", MessageBoxButton.OK);
                    Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("AccountToegevoegd"));
                    dialogservice.CloseCreateAccountDialog();
                }
            }
        }
    }
}
