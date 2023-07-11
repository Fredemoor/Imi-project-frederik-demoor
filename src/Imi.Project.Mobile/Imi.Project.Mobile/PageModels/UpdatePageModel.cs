using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Domain.Enums;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;
using Imi.Project.Mobile.Domain.Validators;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.PageModels
{
    public class UpdatePageModel : FreshBasePageModel
    {

        private readonly ApiAnimalService _animalService;
        private readonly IValidator _animalValidator;
        public Animal SelectedAnimal { get; set; }

        public UpdatePageModel(ApiAnimalService animalService)
        {
            _animalService = animalService;
            _animalValidator = new AnimalValidator();
        }

        #region PROPS /////////////////////////////

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        private string _nameEntryError;
        public string NameEntryError
        {
            get => _nameEntryError;
            set
            {
                _nameEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(NameEntryErrorVisible));
            }
        }

        public bool NameEntryErrorVisible => !string.IsNullOrEmpty(_nameEntryError);

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

        private string breedEntryError;

        public string BreedEntryError
        {
            get => breedEntryError;
            set
            {
                breedEntryError = value;
                RaisePropertyChanged(nameof(BreedEntryError));
                RaisePropertyChanged(nameof(BreedEntryErrorVisible));
            }
        }

        public bool BreedEntryErrorVisible
        {
            get { return !string.IsNullOrEmpty(breedEntryError); }
        }

        private string description;
        public string Description
        {
            get => description;
            set
            {
                description = value;
                RaisePropertyChanged();
            }
        }

        private string descriptionEntryError;
        public string DescriptionEntryError
        {
            get => descriptionEntryError;
            set
            {
                descriptionEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(DescriptionEntryErrorVisible));
            }
        }

        public bool DescriptionEntryErrorVisible
        {
            get { return !string.IsNullOrEmpty(descriptionEntryError); }
        }

        private Gender gender;
        public Gender Gender
        {
            get => gender;
            set
            {
                gender = value;
                RaisePropertyChanged();
            }
        }


        private string imageUrl;

        public string ImageUrl
        {
            get => imageUrl;
            set
            {
                imageUrl = value;
                RaisePropertyChanged();
            }
        }


        private DateTime birthdate;

        public DateTime Birthdate
        {
            get => birthdate;
            set
            {
                birthdate = value;
                RaisePropertyChanged();

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

        private string ageEntryError;

        public string AgeEntryError
        {
            get => ageEntryError;
            set
            {
                ageEntryError = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(AgeEntryErrorVisible));
            }
        }

        public bool AgeEntryErrorVisible => !string.IsNullOrEmpty(ageEntryError);

        private bool isFed;

        public bool IsFed
        {
            get => isFed;
            set
            {
                isFed = value;
                RaisePropertyChanged(nameof(IsFed));
            }
        }

        private bool isWalked;

        public bool IsWalked
        {
            get => isWalked;
            set
            {
                isWalked = value;
                RaisePropertyChanged(nameof(isWalked));
            }
        }

        #endregion

        public ICommand CameraCommand => new Command(() =>
        {
            CoreMethods.DisplayAlert("Camera not functional", "Camera disabled", "ok");
        });

        public ICommand SaveCommand => new Command(
            async () =>
            {
                UpdateAnimalState();
                try
                {
                    if (Validate(SelectedAnimal))
                    {
                        await _animalService.UpdateAsync(SelectedAnimal);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.Message);
                    await CoreMethods.DisplayAlert("Error", ex.Message, "Ok");
                }
                await CoreMethods.PushPageModel<DogListPageModel>();
            });

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
            Description = SelectedAnimal.Description;
            IsFed = SelectedAnimal.IsFed;
            IsWalked = SelectedAnimal.IsWalked;
        }
        public void UpdateAnimalState()
        {
            SelectedAnimal.Name = Name;
            SelectedAnimal.Gender = Gender;
            SelectedAnimal.Breed = Breed;
            SelectedAnimal.Media = ImageUrl;
            SelectedAnimal.Birthdate = Birthdate;
            SelectedAnimal.Description = Description;
            SelectedAnimal.IsFed = IsFed;
            SelectedAnimal.IsWalked = IsWalked;
        }

        private bool Validate(Animal animal)
        {
            NameEntryError = "";
            AgeEntryError = "";
            DescriptionEntryError = "";
            BreedEntryError = "";

            var validationContext = new ValidationContext<Animal>(animal);
            var validationResult = _animalValidator.Validate(validationContext);
            //loop through error to identify properties
            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(animal.Name))
                {
                    NameEntryError = error.ErrorMessage;
                }
                if (error.PropertyName == nameof(animal.Description))
                {
                    DescriptionEntryError = error.ErrorMessage;
                }
                if (error.PropertyName == nameof(animal.Breed))
                {
                    BreedEntryError = error.ErrorMessage;
                }
                if (error.PropertyName == nameof(animal.Birthdate))
                {
                    AgeEntryError = error.ErrorMessage;
                }

            }
            return validationResult.IsValid;
        }
    }
}
