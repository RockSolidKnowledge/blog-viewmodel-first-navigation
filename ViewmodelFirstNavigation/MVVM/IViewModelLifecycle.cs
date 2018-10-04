using System.Threading.Tasks;

namespace ViewmodelFirstNavigation.MVVM
{
    public interface IViewModelLifecycle
    {
        /// <summary>
        /// Called exactly once, before the viewmodel enters the navigation stack
        /// </summary>
        Task BeforeFirstShown();

        /// <summary>
        /// Called exactly once, when the viewmodel leaves the navigation stack
        /// </summary>
        Task AfterDismissed();

        // You may also wish to implement any of the following...
        //Task BeforeAppearing(); // Called before a viewmodel appears, when navigating either forwards or backwards
        //Task AfterAppearing(); // Called after a viewmodel appears, when navigating either forwards or backwards
        //Task BeforeNavigateAway(); // Called before a viewmodel disappears, when navigating either forwards or backwards
        //Task AfterNavigateAway(); // Called after a viewmodel disappears, when navigating either forwards or backwards
    }
}
