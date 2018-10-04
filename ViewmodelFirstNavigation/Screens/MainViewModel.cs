using System.Windows.Input;
using ViewmodelFirstNavigation.MVVM;
using ViewmodelFirstNavigation.Navigation;
using Xamarin.Forms;

namespace ViewmodelFirstNavigation.Screens
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigator;

        public MainViewModel(INavigationService navigator)
        {
            _navigator = navigator;

            NavigationPath = "/Root";

            NavigateToChildPageCommand = new Command(() => { _navigator.NavigateTo(new ChildViewModel(_navigator, $"{NavigationPath}/Child")); });
        }

        public ICommand NavigateToChildPageCommand { get; }

        public string NavigationPath { get; }
    }
}
