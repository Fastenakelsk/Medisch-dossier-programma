using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medisch_dossier_programma.View;
using System.Windows;

namespace Medisch_dossier_programma.Extensions
{
    public class DialogService
    {
        private Window studentDetailView = null;
        private Window studentToevoegenView = null;
        private Window mainWindowView = null;
        private Window inloggenWindow = null;
        private Window createAccountWindow = null;
        private Window vaccinatieWindow = null;
        private Window createVaccinatieWindow = null;
        private Window vaccinatieDetailWindow = null;
        private Window accountsWindow = null;
        private Window vaccinatieLijstWindow = null;
        private Window vaccinatieLijstToevoegenWindow = null;
        private Window changePasswordWindow = null;

        public DialogService() { }

        public void showMainWindow()
        {
            mainWindowView = new MainWindow();
            mainWindowView.Show();
            Application.Current.Windows[0].Close();
        }

        public void ShowToevoegenDialog()
        {
            studentToevoegenView = new ToevoegenWindow();
            studentToevoegenView.ShowDialog();
        }

        public void ShowVaccinatieLijstToevoegenDialog()
        {
            vaccinatieLijstToevoegenWindow = new VaccinatieLijstToevoegenWindow();
            vaccinatieLijstToevoegenWindow.ShowDialog();
        }

        public void CloseToevoegenDialog()
        {
            if (studentToevoegenView != null)
            {
                studentToevoegenView.Close();
            }
        }

        public void ShowVaccinatieDialog()
        {
            vaccinatieWindow = new VaccinatieWindow();
            vaccinatieWindow.ShowDialog();
        }

        public void ShowCreateAccountDialog()
        {
            createAccountWindow = new CreateAccountWindow();
            createAccountWindow.ShowDialog();
        }

        public void CloseCreateAccountDialog()
        {
            if (createAccountWindow != null)
            {
                createAccountWindow.Close();
            }
        }

        public void ShowInloggenDialog()
        {
            inloggenWindow = new InloggenWindow();
            inloggenWindow.ShowDialog();
        }

        public void ShowDetailDialog()
        {
            studentDetailView = new DetailWindow();
            studentDetailView.ShowDialog();
        }

        public void ShowCreateVaccinatieDialog()
        {
            createVaccinatieWindow = new CreateVaccinationWindow();
            createVaccinatieWindow.ShowDialog();
        }

        public void VaccinatieDetailDialog()
        {
            vaccinatieDetailWindow = new VaccinatieDetailWindow();
            vaccinatieDetailWindow.ShowDialog();
        }

        public void CloseCreateVaccinatieDialog()
        {
            if (createVaccinatieWindow != null)
            {
                createVaccinatieWindow.Close();
            }
        }

        public void CloseDetailDialog()
        {
            if (studentDetailView != null)
            {
                studentDetailView.Close();
            }
        }
        public void ShowAccountsWindow()
        {
            accountsWindow = new AccountsWindow();
            accountsWindow.ShowDialog();
        }

        public void ShowVaccinatieLijstWindow()
        {
            vaccinatieLijstWindow = new VaccinatieLijstWindow();
            vaccinatieLijstWindow.ShowDialog();
        }

        public void ShowChangePasswordWindow()
        {
            changePasswordWindow = new ChangePasswordWindow();
            changePasswordWindow.ShowDialog();
        }
    }
}
