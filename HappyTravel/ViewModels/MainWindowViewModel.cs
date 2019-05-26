using HappyTravel.Tools;

namespace HappyTravel.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        #region Fields
        private bool _isControlEnabled = true;
        #endregion

        #region Properties
        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
