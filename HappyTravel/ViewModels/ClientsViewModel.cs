using HappyTravel.Models;
using HappyTravel.Tools;
using HappyTravel.Tools.Managers;
using HappyTravel.Tools.Navigation;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace HappyTravel.ViewModels
{
    internal class ClientsViewModel : BaseViewModel
    {
        #region Fields
        #region Commands
        private RelayCommand<object> _addCommand;
        private RelayCommand<object> _closeCommand;
        #endregion
        #endregion

        #region Properties
        public ObservableCollection<Client> Clients { get; private set; }
        public CollectionViewSource ViewSource { get; private set; }
        #endregion

        #region Constructors
        internal ClientsViewModel()
        {
            Clients = StationManager.DataStorage.GetClients();
            this.ViewSource = new CollectionViewSource();
            ViewSource.Source = this.Clients;
        }
        #endregion

        #region Commands

        public RelayCommand<object> AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new RelayCommand<object>(
                           o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.AddClientView);
                           }));
            }
        }
        public RelayCommand<object> CloseCommand
        {
            get
            {
                return _closeCommand ?? (_closeCommand = new RelayCommand<object>(
                           o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.MainManager);
                           }));
            }
        }
        #endregion
    }
}