using HappyTravel.Tools.Navigation;
using HappyTravel.ViewModels;
using System.Windows.Controls;

namespace HappyTravel.Views
{
    /// <summary>
    /// Логика взаимодействия для ClientsView.xaml
    /// </summary>
    public partial class ClientsView : UserControl, INavigatable
    {
        public ClientsView()
        {
            InitializeComponent();
            DataContext = new ClientsViewModel();
        }
    }
}
