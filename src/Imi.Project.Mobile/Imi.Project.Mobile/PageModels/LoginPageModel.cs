using FreshMvvm;
using Imi.Project.Mobile.Domain.Consts;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.PageModels
{
    public class LoginPageModel : FreshBasePageModel
    {
        private User CurrentUser { get; set; }
        protected readonly ApiUserService _loginService;
        public LoginPageModel(ApiUserService loginService)
        {
            _loginService = loginService;
        }

        public LoginPageModel()
        {

        }


        private string username;

        public string Username
        {
            get => username;
            set
            {
                username = value;
                RaisePropertyChanged();
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged();
            }
        }

        public string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged();
            }
        }

        public string confirmedpassword;
        private DateTime _minDate = new DateTime(2018, 1, 1);

        public string Confirmedpassword
        {
            get { return confirmedpassword; }
            set
            {
                confirmedpassword = value;
                RaisePropertyChanged();
            }
        }

        public ICommand RegisterCommand => new Command(() =>
        {
            CoreMethods.PushPageModel<RegisterPageModel>();
        });

        public ICommand GoToHomeCommand => new Command(() =>
        {
            CoreMethods.SwitchOutRootNavigation(NavigationContainerNames.MainContainer);
        }
        );

    }
}
