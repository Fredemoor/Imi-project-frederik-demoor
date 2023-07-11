using FreshMvvm;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.PageModels
{
    public class DogListPageModel : FreshBasePageModel
    {

        private ApiAnimalService _animalService;

        public DogListPageModel(ApiAnimalService animalService)
        {
            _animalService = animalService;
        }

        #region Properties ///////////////////////////

        private Animal selectedAnimal;

        public Animal SelectedAnimal
        {
            get { return null; }
            set
            {
                selectedAnimal = value;
                if (selectedAnimal != null)
                {
                    CoreMethods.PushPageModel<DogDetailPageModel>(selectedAnimal);
                    RaisePropertyChanged(nameof(selectedAnimal));
                }
            }
        }

        private string media;

        public string Media
        {
            get { return media; }
            set
            {
                media = value;
                RaisePropertyChanged(nameof(Media));
            }
        }

        private ObservableCollection<Animal> animals;

        public ObservableCollection<Animal> Animals
        {
            get { return animals; }
            set
            {
                animals = value;
                RaisePropertyChanged(nameof(Animals));
            }
        }

        private ObservableCollection<Breed> breeds;

        public ObservableCollection<Breed> Breeds
        {
            get { return breeds; }
            set
            {
                breeds = value;
                RaisePropertyChanged(nameof(Breeds));
            }
        }

        private ObservableCollection<Location> locations;

        public ObservableCollection<Location> Locations
        {
            get { return locations; }
            set
            {
                locations = value;
                RaisePropertyChanged(nameof(Locations));
            }
        }

        private ObservableCollection<Media> medias;

        public ObservableCollection<Media> Medias
        {
            get { return medias; }
            set
            {
                medias = value;
                RaisePropertyChanged(nameof(Locations));
            }
        }

        #endregion


        //vervangen met messagecenter zie cxursus
        private bool isRefreshing;

        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                RaisePropertyChanged();

            }
        }



        public ICommand EditCommand => new Command(() =>
        {
            CoreMethods.PushPageModel<UpdatePageModel>(selectedAnimal);
        });

        public ICommand RefreshCommand => new Command(async () =>
        {
            if (IsRefreshing) return;
            try
            {
                var animals = await _animalService.GetAllAsync();
                Animals = new ObservableCollection<Animal>(animals);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        });

        public override async void Init(object initData)
        {
            base.Init(initData);

            var animals = await _animalService.GetAllAsync();
            Animals = new ObservableCollection<Animal>(animals);
        }
    }
}
