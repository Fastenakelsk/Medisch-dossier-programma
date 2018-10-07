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
    class AccountsWindowViewModel : BaseViewModel
    {
        private DialogService dialogservice = new DialogService();

        private ObservableCollection<Account> accounts;
        public ObservableCollection<Account> Accounts
        {
            get { return accounts; }
            set
            {
                accounts = value;
                NotifyPropertyChanged();
            }
        }

        private Account selectedAccount;
        public Account SelectedAccount
        {
            get { return selectedAccount; }
            set
            {
                selectedAccount = value;
                NotifyPropertyChanged();
            }
        }

        public AccountsWindowViewModel()
        {
            getAccounts();
            KoppelenCommands();
            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);
        }

        private void getAccounts()
        {
            AccountDataService aDS = new AccountDataService();
            Accounts = aDS.GetNonAdminAccounts();
        }

        public ICommand ToevoegenCommand { get; set; }
        public ICommand VerwijderenCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        private void KoppelenCommands()
        {
            ToevoegenCommand = new BaseCommand(AccountToevoegen);
            VerwijderenCommand = new BaseCommand(AccountVerwijderen);
            ResetCommand = new BaseCommand(ResetAccount);
        }

        private void AccountToevoegen()
        {
            dialogservice.ShowCreateAccountDialog();
        }
        
        private void AccountVerwijderen()
        {
            AccountDataService aDS = new AccountDataService();

            MessageBoxResult result = MessageBox.Show("Bent u zeker dat u dit account wilt verwijderen ?",
                "Account verwijderen", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                aDS.VerwijderAccount(SelectedAccount);
                getAccounts();
            }
        }

        private void ResetAccount()
        {
            AccountDataService aDS = new AccountDataService();

            MessageBoxResult result = MessageBox.Show("Bent u zeker dat u het wachtwoord van dit account wilt resetten ?",
    "Account resetten", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                aDS.ResetAccount(SelectedAccount);
                MessageBox.Show("Het wachtwoord van " + SelectedAccount.GebruikersNaam + " is nu 123456, " + SelectedAccount.GebruikersNaam + " kan nu zijn of haar wachtwoord aanpassen via het login scherm.",
                    "Wachtwoord reset", MessageBoxButton.OK);
                getAccounts();
            }
        }
        
        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            if (message.State == "AccountToegevoegd")
            {
                getAccounts();
            }
        }
    }
}
