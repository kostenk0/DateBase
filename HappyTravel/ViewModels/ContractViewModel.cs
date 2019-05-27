using HappyTravel.Models;
using HappyTravel.Tools;
using HappyTravel.Tools.Managers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HappyTravel.ViewModels
{
    internal class ContractViewModel : BaseViewModel
    {
        public ObservableCollection<Contract> Contract { get; private set; }
        public CollectionViewSource ViewSource { get; private set; }

        internal ContractViewModel()
        {
            Contract = StationManager.DataStorage.GetContract();
            this.ViewSource = new CollectionViewSource();
            ViewSource.Source = this.Contract;
        }
    }
}
