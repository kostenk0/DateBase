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
    internal class PassViewModel : BaseViewModel
    {
        public ObservableCollection<Pass> Pass { get; private set; }
        public CollectionViewSource ViewSource { get; private set; }

        internal PassViewModel()
        {
            Pass = StationManager.DataStorage.GetPass();
            this.ViewSource = new CollectionViewSource();
            ViewSource.Source = this.Pass;
        }
    }
}
