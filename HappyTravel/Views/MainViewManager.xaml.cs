using HappyTravel.Tools.Navigation;
using HappyTravel.ViewModels;
using System.Windows.Controls;

namespace HappyTravel.Views
{
    /// <summary>
    /// Логика взаимодействия для MainViewManager.xaml
    /// </summary>
    public partial class MainViewManager : UserControl, INavigatable
    {
        public MainViewManager()
        {
            InitializeComponent();
            DataContext = new MainViewManagerModel();
        }
    }
}
