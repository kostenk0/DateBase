using HappyTravel.Tools.Navigation;
using HappyTravel.ViewModels.Authentication;
using System.Windows.Controls;

namespace HappyTravel.Views.Authentication
{
    /// <summary>
    /// Логика взаимодействия для SignUpView.xaml
    /// </summary>
    public partial class SignUpView : UserControl, INavigatable
    {
        public SignUpView()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel();
        }
    }
}
