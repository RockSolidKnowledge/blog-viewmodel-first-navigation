using ViewmodelFirstNavigation.MVVM;
using Xamarin.Forms;

namespace ViewmodelFirstNavigation.Navigation
{
    public interface IViewLocator
    {
        Page CreateAndBindPageFor<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase;
    }
}
