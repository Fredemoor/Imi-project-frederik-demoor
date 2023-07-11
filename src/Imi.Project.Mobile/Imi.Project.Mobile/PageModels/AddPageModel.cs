using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Domain.Enums;
using Imi.Project.Mobile.Domain.Services.Interfaces;
using Imi.Project.Mobile.Domain.Validators;
using MvvmHelpers.Commands;
using System;
using System.Windows.Input;

namespace Imi.Project.Mobile.PageModels
{
    public class AddPageModel : FreshBasePageModel
    {

        private IAnimalService _animalService;
        private IValidator _animalValidator;
        public AddPageModel(IAnimalService animalService)
        {
            _animalService = animalService;
            _animalValidator = new AnimalValidator();
        }

        #region Prop

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string nameEntryError;
        public string NameEntryError
        {
            get { return nameEntryError; }
            set
            {
                nameEntryError = value;
                RaisePropertyChanged(nameof(NameEntryError));
                RaisePropertyChanged(nameof(NameEntryErrorVisible));
            }
        }

        public bool NameEntryErrorVisible
        {
            get { return !string.IsNullOrEmpty(nameEntryError); }
        }

        private string breed;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        private string breedEntryError;

        public string BreedEntryError
        {
            get { return breedEntryError; }
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
            get { return description; }
            set { description = value; }
        }

        private string descriptionEntryError;
        public string DescriptionEntryError
        {
            get { return descriptionEntryError; }
            set
            {
                descriptionEntryError = value;
                RaisePropertyChanged(nameof(DescriptionEntryError));
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
            get { return gender; }
            set { gender = value; }
        }


        private string imageUrl;

        public string ImageUrl
        {
            get { return imageUrl; }
            set
            {
                imageUrl = value;
                RaisePropertyChanged(nameof(ImageUrl));
            }
        }


        private DateTime birthdate;

        public DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
                RaisePropertyChanged(nameof(Birthdate));
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

        private string ageEntryError;

        public string AgeEntryError
        {
            get { return ageEntryError; }
            set
            {
                ageEntryError = value;
                RaisePropertyChanged(nameof(AgeEntryError));
                RaisePropertyChanged(nameof(AgeEntryErrorVisible));
            }
        }

        public bool AgeEntryErrorVisible
        {
            get { return !string.IsNullOrEmpty(ageEntryError); }
        }

        private bool isFed;

        public bool IsFed
        {
            get { return isFed; }
            set
            {
                isFed = value;
                RaisePropertyChanged(nameof(IsFed));
            }
        }

        private bool isWalked;

        public bool IsWalked
        {
            get { return isWalked; }
            set
            {
                isWalked = value;
                RaisePropertyChanged(nameof(isWalked));
            }
        }

        #endregion
        public ICommand SaveCommand => new Command(
        async () =>
        {
            await CoreMethods.DisplayAlert("Error", "To be implemented", "Ok");
        });
    }
}
