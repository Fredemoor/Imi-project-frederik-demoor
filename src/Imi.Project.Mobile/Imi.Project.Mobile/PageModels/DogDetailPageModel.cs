using FreshMvvm;
using Imi.Project.Mobile.Domain.Enums;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;


namespace Imi.Project.Mobile.PageModels
{
    public class DogDetailPageModel : FreshBasePageModel
    {


        public Animal SelectedAnimal { get; set; }
        private ApiAnimalService _animalService;

        public DogDetailPageModel(ApiAnimalService animalService)
        {
            _animalService = animalService;

        }

        #region  Properties //////////////////////////

        private string media;

        public string Media
        {
            get { return media; }
            set
            {
                media = value;
                RaisePropertyChanged();
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        private DateTime birthdate;

        public DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Age));
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - birthdate.Year;
                if (birthdate > DateTime.Now.AddYears(-age)) age--;
                return age;
            }
        }

        private Gender gender;
        public Gender Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                RaisePropertyChanged();
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                RaisePropertyChanged();
            }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                RaisePropertyChanged();
            }
        }

        private string breed;

        public string Breed
        {
            get { return breed; }
            set
            {
                breed = value;
                RaisePropertyChanged();
            }
        }

        private bool isFed;

        public bool IsFed
        {
            get { return isFed; }
            set
            {
                isFed = value;
                RaisePropertyChanged();
            }
        }

        private bool isWalked;

        public bool IsWalked
        {
            get { return isWalked; }
            set
            {
                isWalked = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public override void Init(object initData)
        {
            base.Init(initData);
            SelectedAnimal = (Animal)initData;
            LoadAnimalProps();

        }

        public void LoadAnimalProps()
        {
            Name = SelectedAnimal.Name;
            Gender = SelectedAnimal.Gender;
            Breed = SelectedAnimal.Breed;
            Media = SelectedAnimal.Media;
            Birthdate = SelectedAnimal.Birthdate;
            Description = SelectedAnimal.Description;
            Location = SelectedAnimal.Location;
            IsFed = SelectedAnimal.IsFed;
            IsWalked = SelectedAnimal.IsWalked;
        }

        public ICommand UpdatePageCommand => new Command(
           async () =>
           {
               try
               {
                   await CoreMethods.PushPageModel<UpdatePageModel>(SelectedAnimal);
               }
               catch (Exception ex)
               {
                   Debug.WriteLine(ex.Message);
                   throw;
               }
           }
       );

        public ICommand DeleteCommand => new Command<Animal>(
            async (Animal animal) =>
        {
            try
            {

                await _animalService.DeleteAsync(SelectedAnimal.Id);
            }
            catch (Exception ex)
            {

                await CoreMethods.DisplayAlert("Error!", $"{ex.Message}", "ok");
            }

            await CoreMethods.PopToRoot(true);
        });
    }
}
