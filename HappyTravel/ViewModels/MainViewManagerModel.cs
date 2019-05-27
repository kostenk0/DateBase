using HappyTravel.Tools;
using HappyTravel.Tools.Managers;
using HappyTravel.Tools.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTravel.ViewModels
{
    internal class MainViewManagerModel : BaseViewModel
    {
        #region Fields
        #region Commands
        private RelayCommand<object> _getClientsCommand;
        private RelayCommand<object> _getContractsCommand;
        private RelayCommand<object> _getPassesCommand;
        #endregion
        #endregion

        #region Properties
        #endregion

        #region Commands

        public RelayCommand<object> GetClientsCommand
        {
            get
            {
                return _getClientsCommand ?? (_getClientsCommand = new RelayCommand<object>(
                           o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.ClientsView);
                           }));
            }
        }

        public RelayCommand<Object> GetContractsCommand
        {
            get
            {
                return _getContractsCommand ?? (_getContractsCommand = new RelayCommand<object>(
                           o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.ContractView);
                           }));
            }
        }

        public RelayCommand<Object> GetPassesCommand
        {
            get
            {
                return _getPassesCommand ?? (_getPassesCommand = new RelayCommand<object>(o =>
                {
                    NavigationManager.Instance.Navigate(ViewType.PassView);
                }));
            }
        }

        #endregion
    }
}
