using HappyTravel.Tools.Navigation;
using HappyTravel.ViewModels.AddViewsModels;
using System.Windows.Controls;

namespace HappyTravel.Views
{
    /// <summary>
    /// Логика взаимодействия для AddClientView.xaml
    /// </summary>
    public partial class AddClientView : UserControl, INavigatable
    {
        public AddClientView()
        {
            InitializeComponent();
            DataContext = new AddClientViewModel();
        }
    }
}