using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewmodelFirstNavigation.MVVM;
using ViewmodelFirstNavigation.Navigation;
using Xamarin.Forms;

namespace ViewmodelFirstNavigation.Screens
{
    class ChildViewModel : ViewModelBase
    {
        public string NavigationPath { get; }
        private readonly INavigationService _navigator;

        public ChildViewModel(INavigationService navigator, string navigationPath)
        {
            
            _navigator = navigator;

            NavigationPath = navigationPath;
            NavigateToChildPageCommand = new Command(() => { _navigator.NavigateTo(new ChildViewModel(_navigator, $"{NavigationPath}/Child")); });
            NavigateBack = new Command(() => { _navigator.NavigateBack(); });
            NavigateToRoot = new Command(() => { _navigator.NavigateBackToRoot(); });
        }

        public ICommand NavigateToChildPageCommand { get; }
        public ICommand NavigateBack { get; }
        public ICommand NavigateToRoot { get; set; }

        public override Task BeforeFirstShown()
        {
            Debug.WriteLine("Initialise screen");
            return Task.CompletedTask;
        }

        public override Task AfterDismissed()
        {
            Debug.WriteLine("Release screen resources");
            return Task.CompletedTask;
        }
    }
}
