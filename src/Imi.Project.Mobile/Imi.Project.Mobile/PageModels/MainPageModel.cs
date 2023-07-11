using FreshMvvm;

namespace Imi.Project.Mobile.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public string Message { get; set; } = "Welcome";
        //public ICommand RegisterCommand => new Command(
        // () =>
        // {
        //     CoreMethods.SwitchOutRootNavigation(NavigationContainerNames.AuthenticationContainer);
        // }
        // );

        //public ICommand LoginCommand => new Command(
        // () =>
        // {

        // }
        // );
    }
}
