namespace HappyTravel.Tools.Navigation
{
    internal enum ViewType
    {
        SignIn,
        SignUp,
        MainManager,
        ClientsView,
        ContractView,
        PassView,
        AddClientView
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
