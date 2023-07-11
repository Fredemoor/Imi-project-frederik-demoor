using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Domain.Consts;
using Imi.Project.Mobile.Domain.Services.Api;
using Imi.Project.Mobile.Domain.Services.Interfaces;
using Imi.Project.Mobile.Domain.Validators;
using Imi.Project.Mobile.PageModels;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            FreshIOC.Container.Register<IAnimalService, ApiAnimalService>().AsMultiInstance();
            FreshIOC.Container.Register<IUserService, ApiUserService>().AsMultiInstance();
            FreshIOC.Container.Register<ILocationService, ApiLocationService>().AsMultiInstance();
            FreshIOC.Container.Register<IAppHttpClient, AppHttpClient>().AsMultiInstance();
            FreshIOC.Container.Register<IValidator, AnimalValidator>().AsSingleton();
            //FreshIOC.Container.Register<IValidator, UserValidator>().AsSingleton();

            InitializeComponent();

            var LoginPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            var LoginContainer = new FreshNavigationContainer(LoginPage, NavigationContainerNames.AuthenticationContainer);
            DetailNavigationContainer();

            MainPage = LoginContainer;
        }

        public void DetailNavigationContainer()
        {
            var masterDetailNav = new FreshMasterDetailNavigationContainer(NavigationContainerNames.MainContainer);
            masterDetailNav.Init("Menu");

            masterDetailNav.AddPage<HomePageModel>("Homepage", null);
            masterDetailNav.AddPage<DogListPageModel>("Dogs", null);
            masterDetailNav.AddPage<AddPageModel>("Add Doggie", null);
            masterDetailNav.AddPage<KennelListPageModel>("Kennels", null);
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
