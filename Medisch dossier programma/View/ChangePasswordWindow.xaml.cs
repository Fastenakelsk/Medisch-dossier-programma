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
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ingevuldeGebruikersNaam = username.Text;
            string oudPaswoord = oldPassword.Password;
            string nieuwPaswoord = newPassword.Password;
            AccountDataService ds = new AccountDataService();
            Account checkAccount = ds.GetAccount(ingevuldeGebruikersNaam);

            if (checkAccount == null)
            {
                MessageBox.Show("Een account met deze naam bestaat niet", "Account niet gevonden", MessageBoxButton.OK);
            }
            else
            {
                if (checkAccount.GebruikersNaam != ingevuldeGebruikersNaam || checkAccount.Paswoord != oudPaswoord)
                {
                    MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord", "Fout", MessageBoxButton.OK);
                    username.Text = "";
                    oldPassword.Password = "";
                    newPassword.Password = "";
                    
                }
                else
                {
                    if (nieuwPaswoord.Length < 4)
                    {
                        MessageBox.Show("Paswoord moet minimum 4 tekens lang zijn", "Paswoord te kort", MessageBoxButton.OK);
                    }
                    else
                    {
                        ds.ChangePassword(checkAccount, nieuwPaswoord);
                        MessageBox.Show("Password succesvol veranderd, u kan nu inloggen.", "Succes", MessageBoxButton.OK);
                    }
                }
            }
        }
    }
}
