using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Medisch_dossier_programma.View;
using Medisch_dossier_programma.ViewModel;

namespace Medisch_dossier_programma
{
        class ViewModelLocator
        {

        private static MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
        private static DetailWindowViewModel detailWindowViewModel = new DetailWindowViewModel();
        private static ToevoegenWindowViewModel toevoegenWindowViewModel = new ToevoegenWindowViewModel();
        private static VaccinatieWindowViewModel vaccinatieWindowViewModel = new VaccinatieWindowViewModel();
        private static CreateVaccinatieWindowViewModel createVaccinatieWindowViewModel = new CreateVaccinatieWindowViewModel();
        private static VaccinatieDetailWindowViewModel vaccinatieDetailWindowViewModel = new VaccinatieDetailWindowViewModel();
        private static AccountsWindowViewModel accountsWindowViewModel = new AccountsWindowViewModel();
        private static VaccinatieLijstWindowViewModel vaccinatieLijstWindowViewModel = new VaccinatieLijstWindowViewModel();
        private static VaccinatieLijstToevoegenWindowViewModel vaccinatieLijstToevoegenWindowViewModel = new VaccinatieLijstToevoegenWindowViewModel();


        public static MainWindowViewModel MainWindowViewModel
            {
                get
                {
                    return mainWindowViewModel;
                }
            }

        public static DetailWindowViewModel DetailWindowViewModel
        {
            get
            {
                return detailWindowViewModel;
            }
        }

        public static ToevoegenWindowViewModel ToevoegenWindowViewModel
        {
            get
            {
                return toevoegenWindowViewModel;
            }
        }

        public static VaccinatieWindowViewModel VaccinatieWindowViewModel
        {
            get
            {
                return vaccinatieWindowViewModel;
            }
        }

        public static CreateVaccinatieWindowViewModel CreateVaccinatieWindowViewModel
        {
            get
            {
                return createVaccinatieWindowViewModel;
            }
        }

        public static VaccinatieDetailWindowViewModel VaccinatieDetailWindowViewModel
        {
            get
            {
                return vaccinatieDetailWindowViewModel;
            }
        }

        public static AccountsWindowViewModel AccountsWindowViewModel
        {
            get
            {
                return accountsWindowViewModel;
                    
            }
        }

            public static VaccinatieLijstWindowViewModel VaccinatieLijstWindowViewModel
            {
                get
                {
                    return vaccinatieLijstWindowViewModel;
                    
                }
            }

            public static VaccinatieLijstToevoegenWindowViewModel VaccinatieLijstToevoegenWindowViewModel
            {
                get
                {
                    return vaccinatieLijstToevoegenWindowViewModel;
                    
                }
            }
    }
}
