using HappyTravel.Views;
using HappyTravel.Views.Authentication;
using System;

namespace HappyTravel.Tools.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.SignIn:
                    ViewsDictionary.Add(viewType, new SignInView());
                    break;
                case ViewType.SignUp:
                    ViewsDictionary.Add(viewType, new SignUpView());
                    break;
                case ViewType.MainManager:
                    ViewsDictionary.Add(viewType, new MainViewManager());
                    break;
                case ViewType.ClientsView:
                    ViewsDictionary.Add(viewType, new ClientsView());
                    break;
                case ViewType.ContractView:
                    ViewsDictionary.Add(viewType, new ContractView());
                    break;
                case ViewType.PassView:
                    ViewsDictionary.Add(viewType, new PassView());
                    break;
                case ViewType.AddClientView:
                    ViewsDictionary.Add(viewType, new AddClientView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
