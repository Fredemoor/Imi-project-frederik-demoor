using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Domain.Consts;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;
using System;
using System.Windows.Input;
//using Imi.Project.Mobile.Domain.Validators;
using Xamarin.Forms;

namespace Imi.Project.Mobile.PageModels
{
    public class RegisterPageModel : FreshBasePageModel
    {

        protected readonly ApiUserService LoginService;
        //private readonly IValidator _userValidator;
        private User CurrentUser { get; set; }
        public RegisterPageModel(ApiUserService loginService, IValidator userValidator, User currentUser)
        {
            LoginService = loginService;
            CurrentUser = currentUser;
            //_userValidator = userValidator;
        }


        private string _username;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        private string _usernameEntryError;
        public string UsernameEntryError
        {
            get => _usernameEntryError;
            set
            {
                _usernameEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(UsernameEntryErrorVisible));
            }
        }

        public bool UsernameEntryErrorVisible => !string.IsNullOrEmpty(_usernameEntryError);

        private string _email;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                RaisePropertyChanged();
            }
        }

        private string _emailEntryError;

        public string EmailEntryError
        {
            get => _emailEntryError;
            set
            {
                _emailEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(EmailEntryErrorVisible));
            }
        }

        public bool EmailEntryErrorVisible => !string.IsNullOrEmpty(_emailEntryError);


        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        private string _passwordEntryError;
        public string PasswordEntryError
        {
            get => _passwordEntryError;
            set
            {
                _passwordEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(PasswordEntryErrorVisible));
            }
        }
        public bool PasswordEntryErrorVisible => !string.IsNullOrEmpty(_passwordEntryError);


        private string _confirmedPassword;
        public string ConfirmedPassword
        {
            get => _confirmedPassword;
            set
            {
                _confirmedPassword = value;
                RaisePropertyChanged();
            }
        }

        private string _confirmedPasswordEntryError;
        public string ConfirmedPasswordEntryError
        {
            get => _confirmedPasswordEntryError;
            set
            {
                _confirmedPasswordEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ConfirmedPasswordEntryErrorVisible));
            }
        }

        public bool ConfirmedPasswordEntryErrorVisible => !string.IsNullOrEmpty(_confirmedPasswordEntryError);


        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get => _birthdate;
            set
            {
                _birthdate = value;
                RaisePropertyChanged();
            }
        }

        private string _birthdateEntryError;
        public string BirthdateEntryError
        {
            get => _birthdateEntryError;
            set
            {
                _birthdateEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(BirthdateEntryErrorVisible));
            }
        }
        public bool BirthdateEntryErrorVisible => !string.IsNullOrEmpty(_birthdateEntryError);


        private bool _hasAcceptedTermsAndConditions;
        public bool HasAcceptedTermsAndConditions
        {
            get => _hasAcceptedTermsAndConditions;
            set
            {
                _hasAcceptedTermsAndConditions = value;
                RaisePropertyChanged();
            }
        }

        private string _hasAcceptedTermsAndConditionsError;
        public string HasAcceptedTermsAndConditionsError
        {
            get => HasAcceptedTermsAndConditionsError;
            set
            {
                _hasAcceptedTermsAndConditionsError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(HasAcceptedTermsAndConditionsErrorVisible));
            }
        }
        public bool HasAcceptedTermsAndConditionsErrorVisible => !string.IsNullOrWhiteSpace(_hasAcceptedTermsAndConditionsError);



        public ICommand SaveCommand => new Command(async () =>
            {
                GetNewUserData();
                //if (Validate(CurrentUser))
                //{
                try
                {
                    await LoginService.AddUserAsync(CurrentUser);
                }
                catch (Exception exception)
                {
                    await CoreMethods.DisplayAlert("Error", "The user has not been registered", "cancel");
                }

                CoreMethods.SwitchOutRootNavigation(NavigationContainerNames.MainContainer);
                //}
            }
        );

        private void GetNewUserData()
        {
            CurrentUser.Email = Email;
            CurrentUser.Username = Username;
            CurrentUser.Password = Password;
            CurrentUser.ConfirmPassword = ConfirmedPassword;
            CurrentUser.BirthDate = Birthdate;
            CurrentUser.HasAcceptedTermsAndConditions = HasAcceptedTermsAndConditions;
        }

        //private bool Validate(User user)
        //{
        //    UsernameEntryError = "";
        //    EmailEntryError = "";
        //    PasswordEntryError = "";
        //    ConfirmedPasswordEntryError = "";
        //    BirthdateEntryError = "";
        //    HasAcceptedTermsAndConditionsError = "";

        //    var validationContext = new ValidationContext<User>(user);
        //    var validationResult = _userValidator.Validate(validationContext);

        //    foreach (var error in validationResult.Errors)
        //    {
        //        if (error.PropertyName == nameof(user.Username))
        //        {
        //            UsernameEntryError = error.ErrorMessage;
        //        }
        //        if (error.PropertyName == nameof(user.Email))
        //        {
        //            EmailEntryError = error.ErrorMessage;
        //        }
        //        if (error.PropertyName == nameof(user.Password))
        //        {
        //            PasswordEntryError = error.ErrorMessage;
        //        }
        //        if (error.PropertyName == nameof(user.BirthDate))
        //        {
        //            BirthdateEntryError = error.ErrorMessage;
        //        }
        //        if (error.PropertyName == nameof(user.HasAcceptedTermsAndConditions))
        //        {
        //            HasAcceptedTermsAndConditionsError = error.ErrorMessage;
        //        }
        //    }
        //    return validationResult.IsValid;
        //}
    }
}
