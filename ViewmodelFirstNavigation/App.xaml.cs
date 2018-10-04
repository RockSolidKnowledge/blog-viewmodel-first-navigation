using ViewmodelFirstNavigation.Navigation;
using ViewmodelFirstNavigation.Screens;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ViewmodelFirstNavigation
{
    public partial class App : Application, IHaveMainPage
    {
        public App()
        {
            InitializeComponent();

            // Poor man's DI

            var navigator = new NavigationService(this, new ViewLocator());

            var rootViewModel = new MainViewModel(navigator);
            
            navigator.PresentAsNavigatableMainPage(rootViewModel);
        }
    }
}
